using Core.Services;
using Presentation.ViewModels;
using Presentation.Views;

namespace Presentation.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        private readonly IMainView mainView;
        private readonly CommandService commandService;

        public MainPresenter(IMainView mainView, CommandService commandService)
        {
            this.mainView = mainView;
            this.commandService = commandService;
        }

        public async Task Run()
        {
            var commands = await commandService.GetAllCommands();
            var viewModel = commands.Select(c => new CommandViewModel { Name = c.CommandName }).ToList();

            mainView.SetCommandsList(viewModel);
            mainView.Show();
        }
    }
}
