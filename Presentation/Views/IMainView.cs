using Presentation.ViewModels;

namespace Presentation.Views
{
    public interface IMainView : IView
    {
        void SetCommandsList(IEnumerable<CommandViewModel> commands);
    }
}