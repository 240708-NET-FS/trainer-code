using AspDemoApi.DTO;


namespace AspDemoApi.Services;

public interface IPokemonService 
{
    Pokemon CreateNewPokemon(PokemonDTO pokemonToCreate);
    List<Pokemon> GetAllPokemon();
}

public interface ITrainerService
{
    Task<Trainer> CreateTrainer(TrainerDTO newTrainer);
    Task<List<Trainer>> GetAllTrainers();
    Task<Trainer?> GetTrainerById(int id);
    Task<Trainer?> UpdateTrainer(int id, TrainerDTO updateTrainer);
    Task<Trainer?> DeleteTrainer(int id);
}