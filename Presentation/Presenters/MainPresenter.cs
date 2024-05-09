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
        //private readonly ITemplateView templateView;
        // private readonly IEditTemplateView editTemplateView;

        public MainPresenter(IMainView mainView, CommandService commandService, TemplateService templateService)
        {
            this.mainView = mainView;
            this.commandService = commandService;
            this.templateService = templateService;
            this.mainView.DeleteTemplate += (s, e) => RemoveTemplate(s, e);
            this.mainView.SaveTemplate += (s, e) => SaveTemplate(s, e);
            //this.mainView.UpdateTemplate += delegate (object? sender, EventArgs e)
            //{
            //    EditTemplate(sender, e, this.mainView.oldNameTemplate,
            //    this.mainView.newNameTemplate, this.mainView.newBookmarksTemplate);
            //};
            this.mainView.UpdateTemplate += (s, e) => UpdateTemplate(s, e, this.mainView.nameTemplate, this.mainView.Template);
            this.mainView.GetTemplate += (s, e) => GetTemplate(s, this.mainView.Template);

            this.mainView.SaveCommand += (s, e) => SaveCommand(s, e);
            this.mainView.DeleteCommand += (s, e) => DeleteCommad(s, e);
            this.mainView.GetCommand += (s, e) => GetCommand(s, this.mainView.Command);
        }

        // події для сховища даних КОМАНД

        public async Task GetCommand(object sender, CommandViewModel e)
        {
            // отримати команду за назвою
            var cmd = await this.commandService.GetCommand(e.NameCommand);
            // отримати вхідний документ команди
            TemplateViewModel inputTmp = new TemplateViewModel();
            inputTmp.FileName = cmd.First().InputTemplate.FileName;
            inputTmp.FilePath = cmd.First().InputTemplate.FilePath;
            inputTmp.ContentFile = cmd.First().InputTemplate.FileContent;
            inputTmp.BookmarksFile = cmd.First().InputTemplate.FileBookmarks;
            // отримати вихідний шаблон команди
            TemplateViewModel outputTmp = new TemplateViewModel();
            outputTmp.FileName = cmd.First().OutputTemplate.FileName;
            outputTmp.FilePath = cmd.First().OutputTemplate.FilePath;
            outputTmp.ContentFile = cmd.First().OutputTemplate.FileContent;
            outputTmp.BookmarksFile = cmd.First().OutputTemplate.FileBookmarks;

            e.InputTemplate = inputTmp;
            e.OutputTemplate = outputTmp;
            e.CommandSetting = (Dictionary<string, string>)cmd.First().CommandSetting;
        }

        public void DeleteCommad(object sender, EventArgs e)
        {
            this.commandService.DeleteCommand(this.mainView.nameCommand);
        }

        public async void SaveCommand(object sender, EventArgs e)
        {
            var inputTmp = await templateService.CreateTemplate(mainView.Command.InputTemplate.FileName,
                mainView.Command.InputTemplate.FilePath,
                mainView.Command.InputTemplate.ContentFile,
                mainView.Command.InputTemplate.BookmarksFile);
            var outputTmp = await templateService.GetTemplate(mainView.Command.OutputTemplate.FileName);

            _ = this.commandService.CreateCommand(this.mainView.Command.NameCommand, this.mainView.Command.CommandSetting,
                inputTmp, outputTmp.First());
        }

        // події для сховища даних ШАБЛОНІВ

        public async Task GetTemplate(object sender, TemplateViewModel e)
        {
            var tmp = await templateService.GetTemplate(e.FileName);
            e.FilePath = tmp.First().FilePath;
            e.ContentFile = tmp.First().FileContent;
            e.BookmarksFile = tmp.First().FileBookmarks;
        }


        //public void EditTemplate(object? sender, EventArgs e, string oldName, string newName, IDictionary<string, string> newBookmark)
        //{
        //    this.templateService.UpdateTemplate(oldName, newName, newBookmark);
        //}

        public void UpdateTemplate(object? sender, EventArgs e, string oldName, TemplateViewModel newTemplate)
        {
            this.templateService.UpdateTemplate(oldName, newTemplate.FileName, newTemplate.BookmarksFile);
        }

        public void RemoveTemplate(object sender, EventArgs e)
        {
            this.templateService.DeleteTemplate(this.mainView.nameTemplate);
        }

        public async Task SaveTemplate(object sender, EventArgs e)
        {
            var template = await this.templateService.CreateTemplate(this.mainView.Template.FileName,
                this.mainView.Template.FileName, this.mainView.Template.ContentFile,
                this.mainView.Template.BookmarksFile);
            _ = templateService.Save(template);
        }

        public async Task Run()
        {
            //var commands = await commandService.GetAllCommands();
            //var viewModelCommands = commands.Select(c => new CommandViewModel { NameCommand = c.CommandName }).ToList();
            // Dictionary<string, string> dictionaryBookmarks = new Dictionary<string, string>();
            // dictionaryBookmarks.Add("bookmark1", "Текст");

            var templates = await templateService.GetAllTemplates();
            var viewModelTemplates = templates.Select(t => new TemplateViewModel
            {
                FileName = t.FileName,
                FilePath = Path.GetFullPath(t.FilePath),
                BookmarksFile = t.FileBookmarks,
                ContentFile = t.FileContent
            }).ToList();

            // mainView.SetCommandsList(viewModelCommands);
            mainView.SetTemplateList(viewModelTemplates);
            mainView.Show();
        }
    }
}
