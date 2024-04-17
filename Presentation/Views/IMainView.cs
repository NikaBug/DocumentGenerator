using Presentation.ViewModels;

namespace Presentation.Views
{
    public interface IMainView : IView
    {
        void SetCommandsList(IEnumerable<CommandViewModel> commands);
        void SetTemplateList(IEnumerable<TemplateViewModel> templates);
        void SetBookmarksDictionary(IDictionary<string, string> dictionaryBookmarks);
    }
}
