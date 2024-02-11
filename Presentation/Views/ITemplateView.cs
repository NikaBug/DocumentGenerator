using Presentation.ViewModels;

namespace Presentation.Views
{
    public interface ITemplateView : IView
    {
        void SetTemplateList(IEnumerable<TemplateViewModel> templates);
    }
}
