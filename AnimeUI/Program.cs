using AnimeUI;
using AnimeUI.Data.Interfaces.Services;
using AnimeUI.Data.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://dattebayo-api.onrender.com")
});

builder.Services.AddScoped<IGetCharacters, GetCharacter>();

builder.Services.AddRadzenComponents();

await builder.Build().RunAsync();
