namespace AspDemoApi.Models;

public class PokemonDTO
{   
    //This will be our Primary Key eventually for EF Core purposes
    public int DexId { get; set; }
    public int TrainerId { get; set;}
    public string Name { get; set; }
    public string Type1 { get; set; }
    public string? Type2 { get; set; }
}