using Core.Services;
using Presentation.ViewModels;
using Presentation.Views;

namespace Presentation.Presenters
{
    /// <summary>
    /// Презентер шаблона
    /// </summary>
    public class TemplatePresenter : ITemplatePresenter
    {
        private readonly ITemplateView templateView;
        private readonly TemplateService templateService;

        public TemplatePresenter(ITemplateView templateView, TemplateService templateService)
        {
            this.templateView = templateView;
            this.templateService = templateService;
        }

        public async Task Run()
        {
            var templates = await templateService.GetAllTemplates();
            var viewModel = templates.Select(c => new TemplateViewModel { FileName = c.FileName }).ToList();

            templateView.SetTemplateList(viewModel);
            templateView.Show();
        }
    }
}