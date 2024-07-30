using AspDemoApi.DTO;

namespace AspDemoApi.Data;

public interface IPokeRepo 
{
    Pokemon CreateNewPokemon(Pokemon pokemonToCreate);
}

public interface ITrainerRepo
{
    Task<Trainer> CreateNewTrainer(Trainer newTrainer);
    Task<List<Trainer>> GetAllTrainers();
    Task<Trainer?> GetTrainerById(int id);
}