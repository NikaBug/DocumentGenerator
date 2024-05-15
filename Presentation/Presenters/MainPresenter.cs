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
            this.mainView.DeleteTemplate += (s, e) => RemoveTemplate(s, e);
            this.mainView.SaveTemplate += (s, e) => _ = SaveTemplate(s, e);
            //this.mainView.UpdateTemplate += delegate (object? sender, EventArgs e)
            //{
            //    EditTemplate(sender, e, this.mainView.oldNameTemplate,
            //    this.mainView.newNameTemplate, this.mainView.newBookmarksTemplate);
            //};
            this.mainView.UpdateTemplate += (s, e) => UpdateTemplate(s, e, this.mainView.viewNameTemplate, this.mainView.viewTemplate);
            this.mainView.GetTemplate += (s, e) => _ = GetTemplate(s, this.mainView.viewTemplate); // GetTemplate(s, this.mainView.viewTemplate);

            this.mainView.SaveCommand += (s, e) => _ = SaveCommand(s, e);
            this.mainView.DeleteCommand += (s, e) => DeleteCommad(s, e);
            this.mainView.GetCommand += (s, e) => _ = GetCommand(s, this.mainView.viewCommand);
            this.mainView.UpdateCommand += (s, e) => UpdateCommand(s, e, this.mainView.viewNameCommand, this.mainView.viewCommand);
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
            this.commandService.DeleteCommand(this.mainView.viewNameCommand);
        }

        public async Task SaveCommand(object sender, EventArgs e)
        {
            var inputTmp = await templateService.CreateTemplate(mainView.viewCommand.InputTemplate.FileName,
                mainView.viewCommand.InputTemplate.FilePath,
                mainView.viewCommand.InputTemplate.ContentFile,
                mainView.viewCommand.InputTemplate.BookmarksFile);
            var outputTmp = await templateService.GetTemplate(mainView.viewCommand.OutputTemplate.FileName);
            var cmd = await commandService.CreateCommand(this.mainView.viewCommand.NameCommand, this.mainView.viewCommand.CommandSetting,
               inputTmp, outputTmp.Last());

            _ = this.commandService.SaveCommand(cmd);
        }

        // події для сховища даних ШАБЛОНІВ
        public void UpdateCommand(object sender, EventArgs e, string oldName, CommandViewModel newCommand)
        {
            this.commandService.UpdateCommand(oldName, newCommand.NameCommand, newCommand.CommandSetting);
        }

        public async Task GetTemplate(object sender, TemplateViewModel e)
        {
            var tmp = await templateService.GetTemplate(e.FileName);
            e.FilePath = tmp.First().FilePath;
            e.ContentFile = tmp.First().FileContent;
            e.BookmarksFile = tmp.First().FileBookmarks;
        }

        public void UpdateTemplate(object? sender, EventArgs e, string oldName, TemplateViewModel newTemplate)
        {
            this.templateService.UpdateTemplate(oldName, newTemplate.FileName, newTemplate.BookmarksFile);
        }

        public void RemoveTemplate(object sender, EventArgs e)
        {
            this.templateService.DeleteTemplate(this.mainView.viewNameTemplate);
        }

        public async Task SaveTemplate(object sender, EventArgs e)
        {
            var template = await this.templateService.CreateTemplate(this.mainView.viewTemplate.FileName,
                this.mainView.viewTemplate.FilePath, this.mainView.viewTemplate.ContentFile,
                this.mainView.viewTemplate.BookmarksFile);
            _ = templateService.Save(template);
        }

        public async Task Run()
        {

            var templates = await templateService.GetAllTemplates();
            if (templates.Count() != 0)
            {
                var viewModelTemplates = templates.Select(t => new TemplateViewModel
                {
                    FileName = t.FileName,
                    FilePath = Path.GetFullPath(t.FilePath),
                    BookmarksFile = t.FileBookmarks,
                    ContentFile = t.FileContent
                }).ToList();

                mainView.SetTemplateList(viewModelTemplates);
            }

            var commands = await commandService.GetAllCommands();
            if(commands.Count() != 0)
            {
                var viewModelCommands = commands.Select(c => new CommandViewModel 
                { NameCommand = c.CommandName, // назва команди
                  InputTemplate = new TemplateViewModel()  // вхідний документ
                  { FileName = c.InputTemplate.FileName,
                    FilePath = c.InputTemplate.FilePath,
                    ContentFile = c.InputTemplate.FileContent,
                    BookmarksFile= c.InputTemplate.FileBookmarks,
                  },
                  OutputTemplate = new TemplateViewModel() // вихідний шаблон
                  {
                      FileName = c.OutputTemplate.FileName,
                      FilePath = c.OutputTemplate.FilePath,
                      ContentFile = c.OutputTemplate.FileContent,
                      BookmarksFile = c.OutputTemplate.FileBookmarks,
                  },
                  CommandSetting = (Dictionary<string, string>)c.CommandSetting // налаштування

                }).ToList();

                mainView.SetCommandsList(viewModelCommands);
            }
            mainView.Show();
        }
    }
}
