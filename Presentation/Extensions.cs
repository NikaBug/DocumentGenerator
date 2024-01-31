using Core;
using Core.Services;
using Microsoft.Extensions.DependencyInjection;
using Presentation.Presenters;

namespace Presentation
{
    public static class Extensions
    {
        private static void UseCore(IServiceCollection services)
        {
            services.AddInMemoryRepositories();
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<CommandService>();
        }

        private static void AddPresenters(IServiceCollection services)
        {
            services.AddScoped<IMainPresenter, MainPresenter>();
        }
    }
}
