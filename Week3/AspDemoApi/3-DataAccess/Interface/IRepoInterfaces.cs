using AspDemoApi.DTO;

namespace AspDemoApi.Data;

public interface IPokeRepo 
{
    public Pokemon CreateNewPokemon(Pokemon pokemonToCreate);
}

public interface ITrainerRepo
{
    
}