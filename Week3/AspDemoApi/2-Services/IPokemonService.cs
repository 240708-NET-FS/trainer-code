using AspDemoApi.Models;


namespace AspDemoApi.Services;

public interface IPokemonService 
{
    public Pokemon CreateNewPokemon(Pokemon pokemonToCreate);
}