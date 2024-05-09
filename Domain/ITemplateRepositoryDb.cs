namespace Domain
{
    public interface ITemplateRepositoryDb
    {
        public Task InsertTemplate(Template template);
        public Task<IEnumerable<Template>> SelectTemplates(string name);
        public Task DeleteTemplate(string name);
        // public Task UpdateTemplate();

    }
}
