using Core.Services;
using Presentation.ViewModels;
using Presentation.Views;

namespace Presentation.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        private readonly IMainView mainView;
        private readonly CommandService commandService;
        private readonly TemplateService templateService;

        public MainPresenter(IMainView mainView, CommandService commandService, TemplateService templateService)
        {
            this.mainView = mainView;
            this.commandService = commandService;
            this.templateService = templateService;

        }

        public async Task Run()
        {
            //var commands = await commandService.GetAllCommands();
            //var viewModelCommands = commands.Select(c => new CommandViewModel { NameCommand = c.CommandName }).ToList();
           // Dictionary<string, string> dictionaryBookmarks = new Dictionary<string, string>();
           // dictionaryBookmarks.Add("bookmark1", "Текст");

            var templates = await templateService.GetAllTemplates();
            var viewModelTemplates = templates.Select(c => new TemplateViewModel
            {
                FileName = c.FileName,
                DateModificationFile = File.GetLastWriteTime(c.FilePath).ToString(),
                SizeFile = new FileInfo(c.FilePath).Length / 1000,
                BookmarksFile = c.FileBookmarks,
                ContentFile = c.FileContent
            }).ToList();

            // mainView.SetCommandsList(viewModelCommands);
            mainView.SetTemplateList(viewModelTemplates);
            mainView.Show();
        }
    }
}
