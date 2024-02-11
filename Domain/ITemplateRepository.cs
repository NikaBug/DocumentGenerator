namespace Domain
{
    /// <summary>
    /// Interface template repository
    /// </summary>
    public interface ITemplateRepository
    {
        Task<Template> Create(string fileName, byte[] fileContent);
        Task<IEnumerable<Template>> Get(string name);
        Task Update(Template oldTemplate, Template newTemplate);
        Task Save(Template template);
        Task Delete(string name);
    }
}
