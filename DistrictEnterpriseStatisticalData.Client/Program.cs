using Blazorise;
using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using DistrictEnterpriseStatisticalData.Client;
using DistrictEnterpriseStatisticalData.Client.Api;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(_ => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<ApiClientWrapper>();

builder.Services.AddBlazorise(options => { options.Immediate = true; }).AddBootstrap5Providers().AddFontAwesomeIcons();

await builder.Build().RunAsync();