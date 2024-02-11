namespace Domain
{
    /// <summary>
    /// Interface command repository
    /// </summary>
    public interface ICommandRepository
    {
        Task<IEnumerable<Command>> Get(string cmdName);
        Task Update(Command oldCommand, Command newCommand);
        Task Save(Command command);
        Task Delete(string cmdName);
    }
}
