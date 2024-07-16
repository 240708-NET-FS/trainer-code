using CompanyApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace CompanyApp;

public class Program
{
    public static void Main(string[] args)
    {
        /*
            CRUD
            Create
            Read
            Update
            Delete
        */
        // Console.WriteLine("Hello there, we are going to make a new department. What is the name?");
        // string name = Console.ReadLine();

        // using (var context = new ApplicationDbContext())
        // {
        //     var department = new Department {DepartmentName = name};

        //     context.Departments.Add(department);
        //     context.SaveChanges();
        // }

        // Console.WriteLine($"{name} has been created");

        using (var context = new ApplicationDbContext())
        {
            // var employee = new Employee {FirstName = "John", LastName = "Doe", DepartmentID = 1, Email = "john.doe@email.com"};

            // context.Employees.Add(employee);
            // context.SaveChanges();
            var employee = context.Employees.Include(e => e.Department)
                            .FirstOrDefault(e => e.FirstName == "John");

            Console.WriteLine(employee);
        }

    }
}