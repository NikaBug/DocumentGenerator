using Domain;

namespace Persistence
{
    /// <summary>
    /// Репозиторій команд в пам'яті
    /// </summary>
    public class InMemoryCommandRepository : ICommandRepository
    {
        private static IList<Command> inMemoryCommands = new List<Command>();

        /// <summary>
        /// Створити команду
        /// </summary>
        /// <param name="commandName">назва команди</param>
        /// <param name="commandSetting">налаштування команди</param>
        /// <param name="inputTemplate">вхідний шаблон</param>
        /// <param name="outputTemplate">вихідний шаблон</param>
        /// <returns>Успішність виконання операції</returns>
        /// <exception cref="ArgumentNullException"></exception>
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
        /// Отримати команду
        /// </summary>
        /// <param name="cmdName">назва команди</param>
        /// <returns>Успішність виконання операції</returns>
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
        /// Оновити команду
        /// </summary>
        /// <param name="oldName"></param>
        /// <param name="newName"></param>
        /// <param name="newSetting"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Task Update(string oldName,
            string newName,
            IDictionary<string, string> newSetting)
        {
            var item = inMemoryCommands.FirstOrDefault(c => c.CommandName == oldName);
            if (item == null)
            {
                throw new ArgumentNullException(nameof(oldName));
            }
            else
            {
                var index = inMemoryCommands.IndexOf(item);
                inMemoryCommands[index].CommandName = newName;
                inMemoryCommands[index].CommandSetting = (IReadOnlyDictionary<string, string>)newSetting;
            }
            return Task.CompletedTask;
        }

        /// <summary>
        /// Зберегти команду
        /// </summary>
        /// <param name="command">назва команди</param>
        /// <returns>Успішність виконання операції</returns>
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
        /// Видалити команду
        /// </summary>
        /// <param name="cmdName">назва команди</param>
        /// <returns>Успішність виконання операції</returns>
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
