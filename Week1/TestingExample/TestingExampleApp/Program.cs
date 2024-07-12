namespace TestingExampleApp;


/*
    Steps to make a testing project (xunit) for an application

    1. Create a new solution and console application project
        - dotnet new sln -n ConsoleApp
        - dotnet new console -n ConsoleApp
        - dotnet sln add ConsoleApp/ConsoleApp.csproj
    
    2. Create a new xUnit test project
        - dotnet new xunit -n ConsoleApp.Tests
        - dotnet sln add ConsoleApp.Tests/ConsoleApp.Tests.csproj
    
    3. Add a reference to the console app in the test project
        - dotnet add ConsoleApp.Tests/ConsoleApp.Tests.csproj reference ConsoleApp/ConsoleApp.csproj

*/

public class Program
{
    public static void Main(string[] args)
    {
        MathOperations mathOperations = new MathOperations();

        int result = mathOperations.Add(1, 2);

        Console.WriteLine("Result of 1 + 2 is: " + result);
    }
}