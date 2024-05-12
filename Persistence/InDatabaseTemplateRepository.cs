using Domain;
using Newtonsoft.Json;
using System.Data.SQLite;
using Template = Domain.Template;

namespace Persistence
{
    public class InDatabaseTemplateRepository : ITemplateRepository
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

        public Task<Template> Create(string fileName, string filePath, byte[] fileContent, Dictionary<string, string> fileBookmarks)
        {
            Template template;
            if (string.IsNullOrEmpty(fileName) || fileContent == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                template = new Template(fileName, filePath, fileContent, fileBookmarks);
            }
            return Task.FromResult(template);
        }

        public Task Delete(string name)
        {
            connection = CreateConnection();
            var command = connection.CreateCommand();
            command.CommandText = @"DELETE FROM Templates WHERE Name=@name";
            command.Parameters.AddWithValue("name", name);
            command.ExecuteNonQuery();
            command.Connection.Close();
            connection.Close();
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Template>> Get(string name)
        {
            connection = CreateConnection();
            var command = connection.CreateCommand();
            byte[] content = new byte[0];
            if (string.IsNullOrEmpty(name))
            {
                command.CommandText = @"SELECT * FROM Templates";
            }
            else
            {
                command.CommandText = @"SELECT * FROM Templates WHERE Name=@name";
                command.Parameters.AddWithValue("@name", name);
            }

            using (var reader = command.ExecuteReader())
            {
                List<Template> templates = new List<Template>();
                while (reader.Read())
                {
                    var _name = reader.GetString(1);
                    var path = reader.GetString(2);
                    content = (byte[])reader["Content"];
                    Dictionary<string, string> bookmarks = JsonConvert.DeserializeObject<Dictionary<string, string>>(reader.GetString(4));
                    templates.Add(new Template(_name, path, content, bookmarks));
                }

                connection.Close();
                return Task.FromResult<IEnumerable<Template>>(templates);
            }
        }

        public Task Save(Template template)
        {
            connection = CreateConnection();

            string insertQuery = "INSERT INTO Templates ('Name','Path','Content','Bookmarks') VALUES(@name,@path,@content,@bookmarks)";
            SQLiteCommand sqlite_cmd = new SQLiteCommand(insertQuery, connection);

            string json_bookmarks = JsonConvert.SerializeObject(template.FileBookmarks);
            sqlite_cmd.Parameters.AddWithValue("name", template.FileName);
            sqlite_cmd.Parameters.AddWithValue("path", template.FilePath);
            sqlite_cmd.Parameters.AddWithValue("content", template.FileContent);
            sqlite_cmd.Parameters.AddWithValue("bookmarks", json_bookmarks);
            var insertResult = sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.Connection.Close();
            connection.Close();

            return Task.FromResult(insertResult);

        }

        public Task Update(string oldName, string newName, IDictionary<string, string> newBookmarks)
        {
            connection = CreateConnection();
            var command = connection.CreateCommand();
            string json_bookmarks = JsonConvert.SerializeObject(newBookmarks);
            command.CommandText = @"UPDATE Templates SET Name=@newname, Bookmarks=@newbookmarks WHERE Name=@oldname";
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
