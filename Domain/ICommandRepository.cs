namespace Domain
{
    /// <summary>
    /// Interface command repository
    /// </summary>
    public interface ICommandRepository
    {
        Task<IEnumerable<Command>> Get(string cmdName);
        Task Save(Command command);
        Task Delete(string cmdName);
    }
}
