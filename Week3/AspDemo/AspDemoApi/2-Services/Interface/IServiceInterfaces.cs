using AspDemoApi.DTO;


namespace AspDemoApi.Services;

public interface IPokemonService 
{
    public Pokemon CreateNewPokemon(PokemonDTO pokemonToCreate);
}

public interface ITrainerService
{
    Task<Trainer> CreateTrainer(TrainerDTO newTrainer);
    Task<List<Trainer>> GetAllTrainers();
    Task<Trainer?> GetTrainerById(int id);
}