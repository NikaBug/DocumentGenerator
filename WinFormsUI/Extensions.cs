using Microsoft.Extensions.DependencyInjection;

namespace WinFormsUI
{
    public static class Extensions
    {
        public static void AddViews(this IServiceCollection services)
        {
            // services.AddScoped<IMainView, FormMain>();
        }
    }
}