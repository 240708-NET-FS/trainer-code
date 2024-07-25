using AspDemoApi.Models;

namespace AspDemoApi.Data;

public interface IPokeRepo 
{
    public Pokemon CreateNewPokemon(Pokemon pokemonToCreate);
}