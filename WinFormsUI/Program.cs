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
            var mainPresenter = host.Services.GetRequiredService<ICommandPresenter>();

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