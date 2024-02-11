namespace Domain
{
    /// <summary>
    /// Interface command repository
    /// </summary>
    public interface ICommandRepository
    {
        Task<Command> Create(string commandName,
            IReadOnlyDictionary<string, string> commandSetting,
            Template inputTemplate,
            Template outputTemplate);
        Task<IEnumerable<Command>> Get(string cmdName);
        Task Update(Command oldCommand, Command newCommand);
        Task Save(Command command);
        Task Delete(string cmdName);
    }
}
