using AspDemoApi.Data;
using AspDemoApi.DTO;
using pUtil = AspDemoApi.Utilities.PokemonUtility;

namespace AspDemoApi.Services;

public class PokemonService : IPokemonService {

    private readonly IPokeRepo _pokeRepo;

    public PokemonService(IPokeRepo pokeRepo)
    {
        this._pokeRepo = pokeRepo;
    }

    public Pokemon CreateNewPokemon(PokemonDTO pokemonToCreate)
    {
        Pokemon newPokemon = pUtil.DTOToPokemon(pokemonToCreate);
        return _pokeRepo.CreateNewPokemon(newPokemon);
    }

    public List<Pokemon> GetAllPokemon()
    {
        return _pokeRepo.GetAllPokemon();
    }

}

