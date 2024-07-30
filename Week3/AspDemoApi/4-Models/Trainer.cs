namespace AspDemoApi.DTO;

public class Trainer
{   
    //This will be our Primary Key eventually for EF Core purposes
    public int TrainerId { get; set; }
    public string Username { get; set; } = "";
    public string Password { get; set; } = "";

    //Setting our one to many between trainers and pokemon
    //Initializing the list so that we can store returned pokemon within it later
    public List<Pokemon> OwnedPokemon { get; set; } = [];
}