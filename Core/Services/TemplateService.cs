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
    }
}
