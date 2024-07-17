using LoginExampleApp.DAO;
using LoginExampleApp.Entities;
using LoginExampleApp.Service;
using LoginExampleApp.Utility;
using LoginExampleApp.Utility.Exceptions;

namespace LoginExampleApp.Controller;

public class LoginController
{

    private LoginService loginService;

    public LoginController(LoginService service)
    {
        loginService = service;
    }

    public void Login()
    {
        Console.WriteLine("ATTEMPTING TO LOGIN");
        Console.WriteLine("Please enter your username: ");

        string username = Console.ReadLine();

        Console.WriteLine("Please enter your password: ");

        string password = Console.ReadLine();

        // Console.WriteLine(username);
        // Console.WriteLine(password);

        try
        {
            Login login = loginService.Login(username, password);
            Console.WriteLine(login);


            Console.WriteLine("Do you want to quit? Type Y or N");

            string input = Console.ReadLine();

            switch(input)
            {
                case "y":
                case "Y":
                    State.isActive = false;
                    break;
                case "N":
                    break;
                default:
                    break;
            }            
        }catch(LoginException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}