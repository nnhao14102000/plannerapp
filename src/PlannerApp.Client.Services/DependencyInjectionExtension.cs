using Microsoft.Extensions.DependencyInjection;
using PlannerApp.Client.Services.Interfaces;

namespace PlannerApp.Client.Services
{
    public static class DependencyInjectionExtension
    {
        public static IServiceCollection AddHttpClientService(this IServiceCollection services)
        {
            return services.AddScoped<IAuthenticationService, HttpAuthenticationService>()
                            .AddScoped<IPlansService, HttpPlansService>();
        }
    }
}
