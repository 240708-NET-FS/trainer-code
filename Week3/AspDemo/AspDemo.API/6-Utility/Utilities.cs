using AspDemoApi.DTO;

namespace AspDemoApi.Utilities;

public static class PokemonUtility
{
    public static Pokemon DTOToPokemon(PokemonDTO pokemonDTO)
    {
        Pokemon newPokemon = new(){
            DexId = pokemonDTO.DexId,
            Name = pokemonDTO.Name,
            Type1 = pokemonDTO.Type1,
            Type2 = pokemonDTO.Type2
        };

        return newPokemon;
    }
}

public static class TrainerUtility
{
    public static Trainer DTOToTrainer(TrainerDTO trainerDTO)
    {
        Trainer newTrainer = new(){
            Username = trainerDTO.Username,
            Password = trainerDTO.Password
        };

        return newTrainer;
    }
}