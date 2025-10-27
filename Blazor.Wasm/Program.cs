using API.Auth.Blazor.WebAssembly;
using API.Clients;
using Blazor.Wasm;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Configurar autenticación
builder.Services.AddSingleton<IAuthService, BlazorWasmAuthService>();

var app = builder.Build();

// Configurar AuthServiceProvider para ApiClients
var authService = app.Services.GetRequiredService<IAuthService>();
AuthServiceProvider.Register(authService);

await app.RunAsync();
