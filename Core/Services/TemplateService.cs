using Domain;

namespace Core.Services
{   /// <summary>
    /// Сервіс для шаблону
    /// </summary>
    public class TemplateService
    {
        private readonly ITemplateRepository templateRepository;

        public TemplateService(ITemplateRepository templateRepository)
        {
            this.templateRepository = templateRepository;
        }
        /// <summary>
        /// Отримати всі шаблони
        /// </summary>
        /// <returns>успішність виконання операції</returns>
        public Task<IEnumerable<Template>> GetAllTemplates()
        {
            return templateRepository.Get(string.Empty);
        }

        /// <summary>
        /// Отримати шаблон
        /// </summary>
        /// <param name="templateName">шаблон</param>
        /// <returns>успішність виконання операції</returns>
        public Task<IEnumerable<Template>> GetTemplate(string templateName)
        {
            return templateRepository.Get(templateName);
        }

        /// <summary>
        /// Створити шаблон
        /// </summary>
        /// <param name="fileName">назва шаблону</param>
        /// <param name="filePath">шлях до шаблону</param>
        /// <param name="fileContent">зміст шаблону</param>
        /// <returns>успішність виконання операції</returns>
        public Task<Template> CreateTemplate(string fileName, string filePath, byte[] fileContent, Dictionary<string, string> fileBookmarks)
        {
            return templateRepository.Create(fileName, filePath, fileContent, fileBookmarks);
        }

        /// <summary>
        /// Оновлення шаблону
        /// </summary>
        /// <param name="oldTemplate">стариий шаблон</param>
        /// <param name="newTemplate">новий шаблон</param>
        /// <returns>успішність виконання операції</returns>
        public Task UpdateTemplate(Template oldTemplate, Template newTemplate)
        {
            return templateRepository.Update(oldTemplate, newTemplate);
        }

        /// <summary>
        /// Видалення шаблону
        /// </summary>
        /// <param name="fileName">назва шаблону</param>
        /// <returns>успішність виконання операції</returns>
        public Task DeleteTemplate(string fileName)
        {
            return templateRepository.Delete(fileName);
        }

        /// <summary>
        /// Збереження шаблону
        /// </summary>
        /// <param name="template">шаблон</param>
        /// <returns>успішність виконання операції</returns>
        public Task Save(Template template)
        {
            return templateRepository.Save(template);
        }
    }
}
