using Core;
using Microsoft.Extensions.DependencyInjection;

namespace Presentation
{
    public static class ExtensionsPresentation
    {
        private static void UseCore(IServiceCollection services)
        {
            services.AddInMemoryRepositories();
        }
    }
}
