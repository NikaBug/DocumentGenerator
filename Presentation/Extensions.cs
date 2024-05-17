using Core;
using Core.Services;
using Microsoft.Extensions.DependencyInjection;
using Presentation.Presenters;

namespace Presentation
{
    public static class Extensions
    {
        /// <summary>
        /// Використати сервіси Core
        /// </summary>
        /// <param name="services">інтерфейс колекції сервісів</param>
        public static void UseCore(this IServiceCollection services)
        {
            services.AddInMemoryRepositories();

            AddServices(services);
            AddPresenters(services);
        }
        /// <summary>
        /// Додати сервіс
        /// </summary>
        /// <param name="services">інтерфейс колекції сервісів</param>
        private static void AddServices(IServiceCollection services)
        {
            services.AddScoped<TemplateService>();
            services.AddScoped<CommandService>();
        }
        /// <summary>
        /// Додати перезентер
        /// </summary>
        /// <param name="services">інтерфейс колекції сервісів<</param>
        private static void AddPresenters(IServiceCollection services)
        {
            services.AddScoped<IMainPresenter, MainPresenter>();
        }
    }
}