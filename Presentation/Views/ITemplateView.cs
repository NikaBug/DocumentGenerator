using Presentation.ViewModels;

namespace Presentation.Views
{   /// <summary>
    /// Інтерфейс представлення шаблона
    /// </summary>
    public interface ITemplateView : IView
    {
        void SetTemplateList(IEnumerable<TemplateViewModel> templates);
    }
}
