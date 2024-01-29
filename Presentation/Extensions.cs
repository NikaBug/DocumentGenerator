using Core;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation
{
    public static class Extensions
    {
        private static void UseCore(IServiceCollection services)
        {
            services.AddInMemoryRepositories();
        }
    }
}
