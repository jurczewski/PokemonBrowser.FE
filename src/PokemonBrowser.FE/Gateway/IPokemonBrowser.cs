using PokemonBrowser.FE.Gateway.Responses;
using Refit;

namespace PokemonBrowser.FE.Gateway;

public interface IPokemonBrowser
{
    [Get("/getByName?name={name}")]
    Task<PokemonResponse> GetPokemon(string name);

    [Get("/getRandom")]
    Task<PokemonResponse> GetRandom();
}
