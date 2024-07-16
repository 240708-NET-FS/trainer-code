namespace CompanyApp.Entities;

public class Employee
{

    public int EmployeeID {get;set;}
    public string FirstName {get;set;}
    public string LastName {get;set;}
    public int DepartmentID {get;set;}
    public string Email {get;set;}

    public Department Department {get;set;}


    public override string ToString()
    {
        return $"{EmployeeID} {FirstName} {LastName} {Email} {DepartmentID} " + Department.DepartmentName;
    }
}