using Domain;
using Microsoft.Extensions.DependencyInjection;
using Persistence;

namespace Core
{
    public static class Extensions
    {
        public static IServiceCollection AddInMemoryRepositories(this IServiceCollection services)
        {
            services.AddScoped<ITemplateRepository, InMemoryTemplateRepository>();
            services.AddScoped<ICommandRepository, InMemoryCommandRepository>();
            return services;
        }
    }
}