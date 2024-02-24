using Domain;

namespace Persistence
{
    /// <summary>
    /// Репозиторій шаблонів в пам'яті
    /// </summary>
    public class InMemoryTemplateRepository : ITemplateRepository
    {
        private static IList<Template> inMemoryTemplates = new List<Template>();
        /// <summary>
        /// Створити шаблон
        /// </summary>
        /// <param name="fileName">назва шаблону</param>
        /// <param name="fileContent">зміст файлу</param>
        /// <returns>Успішність виконання операції</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public Task<Template> Create(string fileName, string filePath, byte[] fileContent)
        {
            Template template;
            if (string.IsNullOrEmpty(fileName) || fileContent == null)
            {
                throw new ArgumentNullException();
            }
            else
            {
                template = new Template(fileName, filePath, fileContent);
            }
            return Task.FromResult(template);
        }

        /// <summary>
        /// Отримати шаблон
        /// </summary>
        /// <param name="name">назва шаблону</param>
        /// <returns>Успішність виконання операції</returns>
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
        /// Оновити шаблон
        /// </summary>
        /// <param name="oldTemplate">старий шаблон</param>
        /// <param name="newTemplate">новий шаблон</param>
        /// <returns>Успішність виконання операції</returns>
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
        /// Зберегети шаблон
        /// </summary>
        /// <param name="template">шаблон</param>
        /// <returns>Успішність виконання операції</returns>
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
        /// Видалити шаблон
        /// </summary>
        /// <param name="name">назва шаблону</param>
        /// <returns>Успішність виконання операції</returns>
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
