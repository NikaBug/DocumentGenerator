using Presentation.ViewModels;

namespace Presentation.Views
{
    public interface IMainView : IView
    {
        // template model
        public TemplateViewModel Template { get; set; }

        // edit template
        public string nameTemplate { get; set; }

        // evets template
        public event EventHandler? SaveTemplate;
        public event EventHandler? DeleteTemplate;
        public event EventHandler? UpdateTemplate;
        public event EventHandler<TemplateViewModel> GetTemplate;

        // commad model
        public CommandViewModel Command { get; set; }
        public string nameCommand {  get; set; }

        // events command
        public event EventHandler? SaveCommand;
        public event EventHandler? DeleteCommand;
        public event EventHandler<CommandViewModel> GetCommand;

        void SetCommandsList(IEnumerable<CommandViewModel> commands);
        void SetTemplateList(IEnumerable<TemplateViewModel> templates);
        void SetBookmarksDictionary(IDictionary<string, string> dictionaryBookmarks);
    }
}
