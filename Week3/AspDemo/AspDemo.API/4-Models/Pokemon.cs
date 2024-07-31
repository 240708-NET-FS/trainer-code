using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace AspDemoApi.DTO;

public class Pokemon
{   
    //This will be our Primary Key eventually for EF Core purposes
    public int PokemonId { get; set; }
    public int DexId { get; set; }
    public string Name { get; set; } = "";
    public string Type1 { get; set; } = "";
    public string? Type2 { get; set; }

    //Setting our one to many between trainers and pokemon
    //Json ignore annotation because when we serialize the pokemon object 
    //we don't care about the owners
    [JsonIgnore]
    public Trainer? Owner { get; set; }

}