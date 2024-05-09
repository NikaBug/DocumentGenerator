using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Presentation;
using Presentation.Presenters;

namespace WinFormsUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            //  var editPresenter = host.Services.GetRequiredService<IEditTemplatePresenter>();
            var mainPresenter = host.Services.GetRequiredService<IMainPresenter>();

            mainPresenter.Run();
            Application.Run();
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder().ConfigureServices((_, services) =>
            {
                services.AddViews();
                services.UseCore();
            });
        }
    }
}