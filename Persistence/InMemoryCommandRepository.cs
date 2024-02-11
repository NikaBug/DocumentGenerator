using Domain;

namespace Persistence
{
    /// <summary>
    /// In memory command repository
    /// </summary>
    public class InMemoryCommandRepository : ICommandRepository
    {
        private static IList<Command> inMemoryCommands = new List<Command>();

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

        /// <summary>
        /// Get command
        /// </summary>
        /// <param name="cmdName">command name</param>
        /// <returns>The successfully completed task</returns>
        public Task<IEnumerable<Command>> Get(string cmdName)
        {
            if (string.IsNullOrEmpty(cmdName))
            {
                return Task.FromResult<IEnumerable<Command>>(inMemoryCommands);
            }
            else
            {
                var commandFound = inMemoryCommands.Where(c => c.CommandName == cmdName);
                return Task.FromResult(commandFound);
            }
        }
        /// <summary>
        /// Update command
        /// </summary>
        /// <param name="oldCommand">old command</param>
        /// <param name="newCommand">new command</param>
        /// <returns>The successfully completed task</returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task Update(Command oldCommand, Command newCommand)
        {
            var item = inMemoryCommands.FirstOrDefault(c => c.CommandName == oldCommand.CommandName);
            if (item == null)
            {
                throw new ArgumentNullException(nameof(oldCommand.CommandName));
            }
            else
            {
                var index = inMemoryCommands.IndexOf(item);
                inMemoryCommands[index] = newCommand;
            }
            return Task.CompletedTask;
        }

        /// <summary>
        /// Save command
        /// </summary>
        /// <param name="command">command name</param>
        /// <returns>The successfully completed task</returns>
        public Task Save(Command command)
        {
            var item = inMemoryCommands.FirstOrDefault(c => c.CommandName == command.CommandName);
            if (item == null)
            {
                inMemoryCommands.Add(command);
            }
            else
            {
                var index = inMemoryCommands.IndexOf(item);
                inMemoryCommands[index] = command;
            }
            return Task.CompletedTask;
        }

        /// <summary>
        /// Delete command
        /// </summary>
        /// <param name="cmdName">command name</param>
        /// <returns>The successfully completed task</returns>
        public Task Delete(string cmdName)
        {
            var item = inMemoryCommands.FirstOrDefault(c => c.CommandName == cmdName);
            if (item != null)
            {
                inMemoryCommands.Remove(item);
            }
            return Task.CompletedTask;
        }


    }
}
