using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.Extensions.DependencyInjection;
using AspNetMonsters.Blazor.Geolocation;


namespace openaq_blazor_wasm
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddSingleton<LocationService>();
            builder.RootComponents.Add<App>("app");

            await builder.Build().RunAsync();
        }
    }
}
