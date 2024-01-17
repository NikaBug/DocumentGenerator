using Domain;

namespace Persistence
{
    /// <summary>
    /// In Memory Template Repository
    /// </summary>
    public class InMemoryTemplateRepository : ITemplateRepository
    {
        private static IList<Template> inMemoryTemplates = new List<Template>();

        /// <summary>
        /// Delete template
        /// </summary>
        /// <param name="name">template name</param>
        /// <returns>The successfully completed task</returns>
        public Task Delete(string name)
        {
            var item = inMemoryTemplates.FirstOrDefault(t => t.FileName == name);
            if (item != null)
            {
                inMemoryTemplates.Remove(item);
            }
            return Task.CompletedTask;
        }

        /// <summary>
        /// Get template
        /// </summary>
        /// <param name="name">template name</param>
        /// <returns>The successfully completed task</returns>
        public Task<IEnumerable<Template>> Get(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return Task.FromResult<IEnumerable<Template>>(inMemoryTemplates);
            }
            else
            {
                var templateFound = inMemoryTemplates.Where(t => t.FileName == name);
                return Task.FromResult(templateFound);
                }
            }

        /// <summary>
        /// Save template
        /// </summary>
        /// <param name="template">template</param>
        /// <returns>The successfully completed task</returns>
        public Task Save(Template template)
        {
            var item = inMemoryTemplates.FirstOrDefault(t => t.FileName == template.FileName);
            if (item == null)
            {
                inMemoryTemplates.Add(template);
            }
            else
            {
                var index = inMemoryTemplates.IndexOf(item);
                inMemoryTemplates[index] = template;
            }
            return Task.CompletedTask;
        }
    }
}
