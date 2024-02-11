using Presentation.ViewModels;

namespace Presentation.Views
{
    public interface ICommandView : IView
    {
        void SetCommandsList(IEnumerable<CommandViewModel> commands);
    }
}
