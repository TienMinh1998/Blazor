using Blazored.Toast;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using THFontEnd.Services;
using THFontEnd.StateObjects;

namespace THFontEnd
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");
            builder.Services.AddTransient<ITaskApiClient,TaskApiClient>();
            builder.Services.AddBlazoredToast();
            builder.Services.AddSingleton<StateContainer>();
            builder.Services.AddScoped<LoginState>();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://103.11.199.157:8088") });

            await builder.Build().RunAsync();
        }
    }
}
