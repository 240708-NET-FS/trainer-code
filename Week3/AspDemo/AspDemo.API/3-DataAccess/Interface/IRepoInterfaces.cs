using AspDemoApi.DTO;

namespace AspDemoApi.Data;

public interface IPokeRepo 
{
    Pokemon CreateNewPokemon(Pokemon pokemonToCreate);
    List<Pokemon> GetAllPokemon();
    Pokemon? GetPokemonById(int id);
}

public interface ITrainerRepo
{
    Task<Trainer> CreateNewTrainer(Trainer newTrainer);
    Task<List<Trainer>> GetAllTrainers();
    Task<Trainer?> GetTrainerById(int id);
    Task<Trainer?> UpdateTrainer(int id, Trainer updateTrainer);
    Task<Trainer> DeleteTrainer(int id);
}