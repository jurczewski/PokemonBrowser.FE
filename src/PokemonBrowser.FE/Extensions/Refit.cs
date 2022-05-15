using PokemonBrowser.FE.Gateway;
using Refit;

namespace PokemonBrowser.FE.Extensions;

public static class Refit
{
    private const string BaseUrl = "https://pokemon-browser.azurewebsites.net/api/";
    //private const string BaseUrl = "http://localhost:7071/api";
    
    public static void AddRefitConfiguration(this IServiceCollection services)
    {
        services
            .AddRefitClient<IPokemonBrowser>()
            .ConfigureHttpClient(client =>
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            });
    }
}

