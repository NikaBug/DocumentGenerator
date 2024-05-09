namespace Domain
{
    /// <summary>
    /// Інтерфейс репозиторію команд
    /// </summary>
    public interface ICommandRepository
    {
        Task<Command> Create(string commandName,
            IReadOnlyDictionary<string, string> commandSetting,
            Template inputTemplate,
            Template outputTemplate);
        Task<IEnumerable<Command>> Get(string cmdName);
        Task Update(string oldName,
            string newName,
            IDictionary<string, string> newSetting);
        Task Save(Command command);
        Task Delete(string cmdName);
    }
}
