using Presentation.ViewModels;

namespace Presentation.Views
{
    /// <summary>
    /// Інтерфейс представлення команд
    /// </summary>
    public interface ICommandView : IView
    {
        void SetCommandsList(IEnumerable<CommandViewModel> commands);
    }
}
