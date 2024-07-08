using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorApp1;
using Kinde.Api.Models.Configuration;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddTransient<IAuthorizationConfigurationProvider, DefaultAuthorizationConfigurationProvider>();
builder.Services.AddTransient<IApplicationConfigurationProvider, DefaultApplicationConfigurationProvider>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();
await builder.Build().RunAsync();