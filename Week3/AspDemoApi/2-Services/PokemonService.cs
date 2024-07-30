using AspDemoApi.Data;
using AspDemoApi.DTO;

namespace AspDemoApi.Services;

public class PokemonService : IPokemonService {

    private readonly IPokeRepo _pokeRepo;

    public PokemonService(IPokeRepo pokeRepo)
    {
        this._pokeRepo = pokeRepo;
    }

    public Pokemon CreateNewPokemon(PokemonDTO pokemonToCreate)
    {
        Pokemon newPokemon = new(){
            DexId = pokemonToCreate.DexId,
            Name = pokemonToCreate.Name,
            Type1 = pokemonToCreate.Type1,
            Type2 = pokemonToCreate.Type2
        };

        return _pokeRepo.CreateNewPokemon(newPokemon);
    }

}

