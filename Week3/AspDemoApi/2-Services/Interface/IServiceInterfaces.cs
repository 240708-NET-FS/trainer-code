using AspDemoApi.DTO;


namespace AspDemoApi.Services;

public interface IPokemonService 
{
    public Pokemon CreateNewPokemon(PokemonDTO pokemonToCreate);
}

public interface ITrainerService
{
    
}