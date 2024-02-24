using Core.Services;
using Presentation.ViewModels;
using Presentation.Views;

namespace Presentation.Presenters
{
    /// <summary>
    /// Перезентер команд
    /// </summary>
    public class CommandPresenter : ICommandPresenter
    {
        private readonly ICommandView commandView;
        private readonly CommandService commandService;

        public CommandPresenter(ICommandView commandView, CommandService commandService)
        {
            this.commandView = commandView;
            this.commandService = commandService;
        }

        public async Task Run()
        {
            var commands = await commandService.GetAllCommands();
            var viewModel = commands.Select(c => new CommandViewModel { Name = c.CommandName }).ToList();

            commandView.SetCommandsList(viewModel);
            commandView.Show();
        }

    }
}
