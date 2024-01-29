using Domain;

namespace Core.Services
{
    public class CommandService
    {
        private readonly ICommandRepository commandRepository;

        public CommandService(ICommandRepository commandRepository)
        {
            this.commandRepository = commandRepository;
        }

        public Task<IEnumerable<Command>> GetAllCommands()
        {
            return commandRepository.Get(string.Empty);
        }
    }
}
