using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Todo_App;
using System;
using System.Net.Http;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Register HttpClient for making API calls
builder.Services.AddScoped(sp => new HttpClient
{
    // Set the base address to the API endpoint
    BaseAddress = new Uri("http://localhost:5136/") 
});
await builder.Build().RunAsync();
