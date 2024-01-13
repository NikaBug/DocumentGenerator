using Domain;

namespace Persistence
{
    /// <summary>
    /// In memory command repository
    /// </summary>
    public class InMemoryCommandRepository : ICommandRepository
    {
        private IList<Command> cmd = new List<Command>();

        /// <summary>
        /// Delete command
        /// </summary>
        /// <param name="cmdName">command name</param>
        /// <returns>The successfully completed task</returns>
        public Task Delete(string cmdName)
        {
            bool res = false;
            var item = cmd.FirstOrDefault(c => c.CommandName == cmdName);
            if (item != null)
            {
                res = cmd.Remove(item);
            };
            return Task.FromResult(res);
        }

        /// <summary>
        /// Get command
        /// </summary>
        /// <param name="cmdName">command name</param>
        /// <returns>The successfully completed task</returns>
        public Task<IEnumerable<Command>> Get(string cmdName)
        {
            var list = new List<Command>();
            foreach (var it in cmd)
            {
                if (it.CommandName == cmdName)
                {
                    list.Add(it);
                }
            }
            return Task.FromResult<IEnumerable<Command>>(list);
        }

        /// <summary>
        /// Save command
        /// </summary>
        /// <param name="command">command name</param>
        /// <returns>The successfully completed task</returns>
        public Task Save(Command command)
        {
            cmd.Add(command);
            return Task.CompletedTask;
        }
    }
}
