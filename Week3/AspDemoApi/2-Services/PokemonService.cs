using AspDemoApi.Models;

namespace AspDemoApi.Services;

public class PokemonService : IPokemonService {


    public Pokemon CreateNewPokemon(Pokemon pokemonToCreate)
    {
        return new Pokemon();
    }

}

