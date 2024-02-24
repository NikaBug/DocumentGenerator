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
    }
}
