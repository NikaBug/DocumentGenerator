using Presentation.ViewModels;

namespace Presentation.Views
{
    public interface IMainView : IView
    {
        public TemplateViewModel Template { get; set; }
        public string nameTemplate { get; set; }
        public event EventHandler? SaveTemplate;
        public event EventHandler? DeleteTemplate;
        public event EventHandler? UpdateTemplate;
        public event EventHandler<TemplateViewModel> GetTemplate;

        public CommandViewModel Command { get; set; }
        public string nameCommand { get; set; }
        public event EventHandler? SaveCommand;
        public event EventHandler? DeleteCommand;
        public event EventHandler<CommandViewModel> GetCommand;
        public event EventHandler? UpdateCommand;

        void SetCommandsList(IEnumerable<CommandViewModel> commands);
        void SetTemplateList(IEnumerable<TemplateViewModel> templates);
        void SetBookmarksDictionary(IDictionary<string, string> dictionaryBookmarks);
    }
}
