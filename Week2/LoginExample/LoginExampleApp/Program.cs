using System.Reflection.Metadata;
using LoginExampleApp.Controller;
using LoginExampleApp.DAO;
using LoginExampleApp.Entities;
using LoginExampleApp.Service;
using LoginExampleApp.Utility;

namespace LoginExampleApp;

public class Program
{
    public static void Main(string[] args)
    {
        // Console.WriteLine("Hello");

        using (var context = new ApplicationDbContext())
        {
            UserDAO userDao = new UserDAO(context);
            LoginDAO loginDao = new LoginDAO(context);

            UserService userService = new UserService(userDao);
            LoginService loginService = new LoginService(loginDao);

            UserController userController = new UserController(userService);
            LoginController loginController = new LoginController(loginService);

            State.isActive = true;

            while(State.isActive)
            {
                loginController.Login();
            }


            // userDao.Create(new User{FirstName = "John", LastName = "Doe"});
            // ICollection<User> users = userDao.GetAll();

            // Console.WriteLine(users);

            // foreach (var user in users)
            // {
            //     Console.WriteLine(user);
            // }

            // loginDao.Create(new Login {Username = "user2", Password = "pass2", UserID = 2});

            // userDao.Create(new User{FirstName = "John", LastName = "Doe"});
            // ICollection<Login> logins = loginDao.GetAll();

            // Console.WriteLine(users);

            // foreach (var login in logins)
            // {
            //     Console.WriteLine(login);
            // }


        //     // var user = new User {FirstName = "Mike", LastName = "John"};

        //     // context.Users.Add(user);

        //     var login = new Login {Username = "user1", Password = "pass1", UserID = 1};
        //     context.Logins.Add(login);
        //     context.SaveChanges();
        }



    }
}