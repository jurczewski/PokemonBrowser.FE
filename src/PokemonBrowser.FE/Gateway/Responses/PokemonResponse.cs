namespace PokemonBrowser.FE.Gateway.Responses;

public record PokemonResponse
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? FrontImageUrl { get; set; }
}