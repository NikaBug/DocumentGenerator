using Presentation.ViewModels;

namespace Presentation.Views
{
    public interface IMainView : IView
    {
        void SetTemplateList(IEnumerable<TemplateViewModel> templates);
        void SetCommandsList(IEnumerable<CommandViewModel> commands);
    }
}