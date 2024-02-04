using Domain;

namespace Core.Services
{
    public class TemplateService
    {
        private readonly ITemplateRepository templateRepository;

        public TemplateService(ITemplateRepository templateRepository)
        {
            this.templateRepository = templateRepository;
        }

        public Task<IEnumerable<Template>> GetAllCommands()
        {
            return templateRepository.Get(string.Empty);
        }
    }
}
