using Microsoft.Extensions.DependencyInjection;
using Presentation.Views;

namespace WinFormsUI
{   /// <summary>
    /// Розширення
    /// </summary>
    public static class Extensions
    {   /// <summary>
        /// Додати представлення
        /// </summary>
        /// <param name="services"></param>
        public static void AddViews(this IServiceCollection services)
        {
            services.AddScoped<IMainView, FormMain>();
        }
    }
}
