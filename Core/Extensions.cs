using Domain;
using Microsoft.Extensions.DependencyInjection;
using Persistence;

namespace Core
{
    /// <summary>
    /// Розширення
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Додати до пам'яті репозиторії
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddInMemoryRepositories(this IServiceCollection services)
        {
            services.AddScoped<ITemplateRepository, InMemoryTemplateRepository>();
            services.AddScoped<ICommandRepository, InMemoryCommandRepository>();
            return services;
        }
    }
}