using Domain;
using Microsoft.Extensions.DependencyInjection;
using Persistence;

namespace Core
{
    public static class ExtensionsCore
    {
        public static IServiceCollection AddInMemoryRepositories(this IServiceCollection services)
        {
            services.AddScoped<ITemplateRepository, InMemoryTemplateRepository>();
            services.AddScoped<ICommandRepository, InMemoryCommandRepository>();
            return services;
        }
    }
}
