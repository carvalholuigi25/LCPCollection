using Blazored.LocalStorage;
using LCPCollection.Client;
using LCP = LCPCollection.Client.Pages;
using LCPCollection.Shared.Classes;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();

builder.Services.AddSingleton<ILogger>(provider => provider.GetRequiredService<ILogger<Animes>>());
builder.Services.AddSingleton<ILogger>(provider => provider.GetRequiredService<ILogger<Books>>());
builder.Services.AddSingleton<ILogger>(provider => provider.GetRequiredService<ILogger<Games>>());
builder.Services.AddSingleton<ILogger>(provider => provider.GetRequiredService<ILogger<Movies>>());
builder.Services.AddSingleton<ILogger>(provider => provider.GetRequiredService<ILogger<TVSeries>>());
builder.Services.AddSingleton<ILogger>(provider => provider.GetRequiredService<ILogger<Users>>());
builder.Services.AddSingleton<ILogger>(provider => provider.GetRequiredService<ILogger<LCP.Auth>>());

builder.Services.AddBlazoredLocalStorageAsSingleton();

builder.Services.AddHttpClient("LCPCollection.ServerAPI", client =>
{
    //client.BaseAddress = new Uri($"{builder.HostEnvironment.BaseAddress}api/");
    client.BaseAddress = new Uri($"https://localhost:5000/api/");
});

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("LCPCollection.ServerAPI"));

await builder.Build().RunAsync();
