namespace Domain
{
    /// <summary>
    /// Інтерфейс репозиторію шаблону
    /// </summary>
    public interface ITemplateRepository
    {
        Task<Template> Create(string fileName, string filePath, byte[] fileContent, Dictionary<string, string> fileBookmarks);
        Task<IEnumerable<Template>> Get(string name);
        Task Update(string oldName,
            string newName,
            IDictionary<string, string> newBookmarks);
        Task Save(Template template);
        Task Delete(string name);
    }
}
