namespace Domain
{
    /// <summary>
    /// Interface template repository
    /// </summary>
    public interface ITemplateRepository
    {
        Task<IEnumerable<Template>> Get(string name);
        Task Save(Template template);
        Task Delete(string name);
    }
}
