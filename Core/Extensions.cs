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
        public static IServiceCollection AddInMemoryRepositories(this IServiceCollection services)
        {
            services.AddScoped<ITemplateRepository, InDatabaseTemplateRepository>();
            services.AddScoped<ICommandRepository, InDatabaseCommandsRepository>();
            return services;
        }
    }
}