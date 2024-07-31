namespace AspDemoApi.DTO;

public class PokemonDTO
{   
    //This will be our Primary Key eventually for EF Core purposes
    public int DexId { get; set; }
    public string Name { get; set; } = null!;
    public string Type1 { get; set; } = null!;
    public string? Type2 { get; set; }
}

public class PokemonWithTrainerDTO : PokemonDTO
{   
    //This will be our Primary Key eventually for EF Core purposes
    public int TrainerId { get; set;}
}