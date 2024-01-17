using Domain;

namespace Persistence
{
    /// <summary>
    /// In memory command repository
    /// </summary>
    public class InMemoryCommandRepository : ICommandRepository
    {
        private static IList<Command> inMemoryCommands = new List<Command>();

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
    }
}
