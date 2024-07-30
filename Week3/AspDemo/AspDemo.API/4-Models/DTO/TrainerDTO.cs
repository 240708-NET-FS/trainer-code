namespace AspDemoApi.DTO;

public class TrainerDTO
{   
    //This will be our Primary Key eventually for EF Core purposes
    public string Username { get; set; } = null!;
    public string Password { get; set; } = null!;
}