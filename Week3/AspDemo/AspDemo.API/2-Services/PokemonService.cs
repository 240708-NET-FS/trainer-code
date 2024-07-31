using AspDemoApi.Data;
using AspDemoApi.DTO;
using pUtil = AspDemoApi.Utilities.PokemonUtility;

namespace AspDemoApi.Services;

public class PokemonService : IPokemonService {

    private readonly IPokeRepo _pokeRepo;
    private readonly ITrainerService _trainerService;

    public PokemonService(IPokeRepo pokeRepo, ITrainerService trainerService)
    {
        _pokeRepo = pokeRepo;
        _trainerService = trainerService;
    }

    public Pokemon CreateNewPokemon(PokemonDTO pokemonToCreate)
    {
        Pokemon newPokemon = pUtil.DTOToPokemon(pokemonToCreate);
        return _pokeRepo.CreateNewPokemon(newPokemon);
    }

    public Pokemon? CreatePokemonForTrainer(int trainerId, PokemonDTO pokemonToStore)
    {
        try
        {
            var trainer = _trainerService.GetTrainerById(trainerId).Result;
            if(trainer is not null)
            {
                Pokemon newPokemon = pUtil.DTOToPokemon(pokemonToStore);
                newPokemon.Owner = trainer;
                return _pokeRepo.CreateNewPokemon(newPokemon);
            }
            return null;
        }catch(Exception)
        {
            throw;
        }
    }

    public List<Pokemon> GetAllPokemon()
    {
        return _pokeRepo.GetAllPokemon();
    }

    public Pokemon? GetPokemonById(int id)
    {
        return _pokeRepo.GetPokemonById(id);
    }

}

