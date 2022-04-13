using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ToDoListt.Client;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
builder.Services.AddAuthorizationCore();
builder.Services.AddScoped<AuthenticationStateProvider, TestAuthStateProvider>();

builder.Services.AddHttpClient("BlazorWasmHostedAuth.ServerAPI",
				client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
				.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

builder.Services.AddScoped(sp =>
	sp.GetRequiredService<IHttpClientFactory>()
	.CreateClient("BlazorWasmHostedAuth.ServerAPI"));

builder.Services.AddApiAuthorization();


await builder.Build().RunAsync();
