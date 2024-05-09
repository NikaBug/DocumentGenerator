using Domain;

namespace Core.Services
{
    /// <summary>
    /// Сервіс для команд
    /// </summary>
    public class CommandService
    {
        private readonly ICommandRepository commandRepository;

        public CommandService(ICommandRepository commandRepository)
        {
            this.commandRepository = commandRepository;
        }
        /// <summary>
        /// Отримати всі команди
        /// </summary>
        /// <returns>успішність виконання операції</returns>
        public Task<IEnumerable<Command>> GetAllCommands()
        {
            return commandRepository.Get(string.Empty);
        }

        /// <summary>
        /// Отримати команду
        /// </summary>
        /// <param name="commandName">назва команди</param>
        /// <returns>успішність виконання операції</returns>
        public Task<IEnumerable<Command>> GetCommand(string commandName)
        {
            return commandRepository.Get(commandName);
        }

        /// <summary>
        /// Створення команди
        /// </summary>
        /// <param name="commandName">назва команди</param>
        /// <param name="commandSetting">налаштування команди</param>
        /// <param name="inputTemplate">вхідний шаблон</param>
        /// <param name="outputTemplate">вихідний шаблон</param>
        /// <returns>успішність виконання операції</returns>
        public Task<Command> CreateCommand(string commandName,
            IReadOnlyDictionary<string, string> commandSetting,
            Template inputTemplate,
            Template outputTemplate)
        {
            return commandRepository.Create(commandName, commandSetting, inputTemplate, outputTemplate);
        }

        /// <summary>
        /// Видалення команди
        /// </summary>
        /// <param name="commandName">назва команди</param>
        /// <returns>успішність виконання операції</returns>
        public Task DeleteCommand(string commandName)
        {
            return commandRepository.Delete(commandName);
        }

        /// <summary>
        /// Оновлення команди
        /// </summary>
        /// <param name="oldCommand">стара команда</param>
        /// <param name="newCommand">нова команда</param>
        /// <returns>успішність виконання операції</returns>
        public Task UpdateCommand(string oldName,
            string newName,
            IDictionary<string, string> newSetting)
        {
            return commandRepository.Update(oldName, newName, newSetting);
        }


        /// <summary>
        /// Зберегти команду
        /// </summary>
        /// <param name="command">команда</param>
        /// <returns>успішність виконання операції</returns>
        public Task SaveCommand(Command command)
        {
            return commandRepository.Save(command);
        }
    }
}
