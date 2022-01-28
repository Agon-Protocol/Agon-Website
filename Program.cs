using LudusBet;
using LudusBet.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(x => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddTransient<ErrorService>();
builder.Services.AddTransient<DesmosService>();
builder.Services.AddTransient<KeplrService>();
builder.Services.AddDesmosClient().ConfigureHttpClient(x => x.BaseAddress = new Uri("https://gql.mainnet.desmos.network/v1/graphql"));

builder.Services.AddMudServices(x =>
{
    x.SnackbarConfiguration.PositionClass = "mud-snackbar-location-bottom-right";
});

await builder.Build().RunAsync();