using AKSoftware.Localization.MultiLanguages;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using System;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;

namespace PlannerApp
{
    public partial class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddHttpClient("PlannerApp.Api", client =>
            {
                client.BaseAddress = new Uri("https://plannerapp-api.azurewebsites.net");
            }).AddHttpMessageHandler<AuthorizationMessageHandler>();

            builder.Services.AddTransient<AuthorizationMessageHandler>();

            builder.Services.AddScoped(sp => sp.GetService<IHttpClientFactory>().CreateClient("PlannerApp.Api"));

            builder.Services.AddMudServices();

            builder.Services.AddBlazoredLocalStorage();

            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<AuthenticationStateProvider, JwtAuthenticationStateProvider>();


            builder.Services.AddLanguageContainer(Assembly.GetExecutingAssembly());
            await builder.Build().RunAsync();
        }
    }
}
