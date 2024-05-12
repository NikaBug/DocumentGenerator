using Domain;
using Newtonsoft.Json;
using Spire.Doc;
using System.Data;
using System.Data.SQLite;
using Template = Domain.Template;

namespace Persistence
{
    public class InDatabaseCommandsRepository : ICommandRepository
    {
        private SQLiteConnection connection;

        private SQLiteConnection CreateConnection()
        {
            SQLiteConnection conn = new SQLiteConnection(@"Data Source=..\..\..\..\repos.db; Version = 3;");
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return conn;
        }

        public Task<Command> Create(string commandName,
            IReadOnlyDictionary<string, string> commandSetting,
            Template inputTemplate,
            Template outputTemplate)
        {
            Command command;
            if (string.IsNullOrEmpty(commandName) || commandSetting == null || inputTemplate == null || outputTemplate == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                command = new Command(commandName, commandSetting, inputTemplate, outputTemplate);
            }

            return Task.FromResult(command);
        }

        public Task Delete(string cmdName)
        {
            connection = CreateConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"DELETE FROM Commands WHERE Name=@name";
            command.Parameters.AddWithValue("name", cmdName);
            command.ExecuteNonQuery();
            command.Connection.Close();
            connection.Close();
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Command>> Get(string cmdName)
        {
            connection = CreateConnection();
            var command = connection.CreateCommand();
            if (string.IsNullOrEmpty(cmdName))
            {
                command.CommandText = @"SELECT * FROM Commands";
            }
            else
            {
                command.CommandText = @"SELECT * FROM Commands WHERE Name=@name";
                command.Parameters.AddWithValue("@name", cmdName);
            }

            using (var reader = command.ExecuteReader())
            {
                List<Command> commands = new List<Command>();
                while (reader.Read())
                {
                    var name = reader.GetString(1);
                    var input_document = JsonConvert.DeserializeObject<Template>(reader["InputDoc"].ToString()); 
                    var output_template = JsonConvert.DeserializeObject<Template>(reader["OutputTemplate"].ToString()); 
                    var setting_bookmarks = JsonConvert.DeserializeObject<Dictionary<string, string>>(reader.GetString(4));
                    commands.Add(new Command(name, setting_bookmarks, input_document, output_template));
                }

                connection.Close();
                return Task.FromResult<IEnumerable<Command>>(commands);
            }
        }

        public Task Save(Command command)
        {
            string json_inputdoc = JsonConvert.SerializeObject(command.InputTemplate);
            string json_outputTemplate = JsonConvert.SerializeObject(command.OutputTemplate);
            string json_setting = JsonConvert.SerializeObject(command.CommandSetting);

            connection = CreateConnection();
            string insertQuery = "INSERT INTO Commands ('Name','InputDoc','OutputTemplate','SettingBookmarks') " +
               "VALUES(@name,@inputdoc,@outtemplate,@setting)";
            SQLiteCommand sqlite_cmd = new SQLiteCommand(insertQuery, connection);
            sqlite_cmd.Parameters.AddWithValue("@name", command.CommandName);
            sqlite_cmd.Parameters.AddWithValue("@inputdoc", json_inputdoc);
            sqlite_cmd.Parameters.AddWithValue("@outtemplate", json_outputTemplate);
            sqlite_cmd.Parameters.AddWithValue("@setting", json_setting);
            var insertResult = sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.Connection.Close();
           
            connection.Close();

            return Task.FromResult(insertResult);

        }

        public Task Update(string oldName, string newName, IDictionary<string, string> newSetting)
        {
            connection = CreateConnection();
            string json_bookmarks = JsonConvert.SerializeObject(newSetting);

            var command = connection.CreateCommand();
            command.CommandText = @"UPDATE Commands SET Name=@newname, SettingBookmarks=@newbookmarks WHERE Name=@oldname";
            command.Parameters.AddWithValue("newname", newName);
            command.Parameters.AddWithValue("newbookmarks", json_bookmarks);
            command.Parameters.AddWithValue("oldname", oldName);
            _ = command.ExecuteNonQuery();
            command.Connection.Close();

            connection.Close();
            return Task.CompletedTask;
        }
    }
}
