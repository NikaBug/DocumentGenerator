using Domain;

namespace Persistence
{
    /// <summary>
    /// In Memory Template Repository
    /// </summary>
    public class InMemoryTemplateRepository : ITemplateRepository
    {
        private static IList<Template> inMemoryTemplates = new List<Template>();

        public Task<Template> Create(string fileName, byte[] fileContent)
        {
            Template template;
            if (string.IsNullOrEmpty(fileName) || fileContent == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                template = new Template(fileName, fileContent);
            }
            return Task.FromResult(template);
        }

        /// <summary>
        /// Get template
        /// </summary>
        /// <param name="name">Template name</param>
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
        /// Update template
        /// </summary>
        /// <param name="oldTemplate">old template</param>
        /// <param name="newTemplate">new template</param>
        /// <returns>The successfully completed task</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Task Update(Template oldTemplate, Template newTemplate)
        {
            var item = inMemoryTemplates.FirstOrDefault(t => t.FileName == oldTemplate.FileName);
            if (item == null)
            {
                throw new ArgumentNullException(nameof(oldTemplate.FileName));
            }
            else
            {
                var index = inMemoryTemplates.IndexOf(item);
                inMemoryTemplates[index] = newTemplate;
            }
            return Task.CompletedTask;
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

        /// <summary>
        /// Delete Template
        /// </summary>
        /// <param name="name">Template name</param>
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
    }
}
