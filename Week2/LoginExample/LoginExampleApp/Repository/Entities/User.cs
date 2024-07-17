namespace LoginExampleApp.Entities;

public class User
{
    public int UserID {get;set;}
    public string FirstName {get;set;}
    public string LastName {get;set;}

    public Login Login {get;set;}


    public override string ToString()
    {
        return $"{UserID} {FirstName} {LastName}";
    }
}