namespace CompanyApp.Entities;

public class Department
{
    public int DepartmentID {get;set;}
    public string DepartmentName {get;set;}

    // ICollection is the Interface for Collections and acts as a grouping for the type of employees
    // This creates the Many aspect of the 1-N relationship
    public ICollection<Employee> Employees {get;set;}
}

/*
    1 - 1
        - This means there is only a single connection between each entity
        - For example: A person has a single SSN, and an SSN is connected to a single person

    1 - N / N - 1
        - This means that a single entity is connected to a single item, but that item can be associated with many entities
        - For example: A persons shopping cart and the items inside it
            - There is only 1 shopping cart, that can have many items like a can of fruit
            - That can of fruit can be associated with many shopping carts

    N - N

        - Many things are associated with many other things
        - For example:
            - Shopping Inventory vs Users shopping history
        
        - This uses a bridge table to connect the items together


*/