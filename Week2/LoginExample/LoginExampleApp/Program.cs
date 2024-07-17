using LoginExampleApp.Entities;

namespace LoginExampleApp;

public class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello");

        using (var context = new ApplicationDbContext())
        {
            // var user = new User {FirstName = "Mike", LastName = "John"};

            // context.Users.Add(user);

            var login = new Login {Username = "user1", Password = "pass1", UserID = 1};
            context.Logins.Add(login);
            context.SaveChanges();
        }

    }
}