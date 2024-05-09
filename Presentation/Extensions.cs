using Core;
using Core.Services;
using Microsoft.Extensions.DependencyInjection;
using Presentation.Presenters;

namespace Presentation
{
    public static class Extensions
    {
        public static void UseCore(this IServiceCollection services)
        {
            services.AddInMemoryRepositories();

            AddServices(services);
            AddPresenters(services);
        }

        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<TemplateService>();
            services.AddScoped<CommandService>();
        }

        private static void AddPresenters(IServiceCollection services)
        {
            services.AddScoped<IMainPresenter, MainPresenter>();
            //
            // services.AddScoped<IEditTemplatePresenter, MainPresenter>();
        }
    }
}