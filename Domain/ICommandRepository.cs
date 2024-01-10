namespace Domain
{
    /// <summary>
    /// Interface command repository
    /// </summary>
    public interface ICommandRepository
    {
        Task<IEnumerable<Command>> Get(string cmdName);
        Task Save(string cmdName);
        Task Delete(string cmdName);
    }
}
