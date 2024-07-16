using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CompanyApp.Entities;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {}

    public ApplicationDbContext(){}
    
    public DbSet<Department> Departments {get;set;}
    public DbSet<Employee> Employees {get;set;}


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // base.OnConfiguring(optionsBuilder);
        if (!optionsBuilder.IsConfigured)
        {
            // Using the Builder Design Pattern
            // We create an object of builder, and then use methods to build out the object to the type we want and then run a build method
            IConfigurationRoot configuration = new ConfigurationBuilder()
                                                .SetBasePath(Directory.GetCurrentDirectory())
                                                .AddJsonFile("appsettings.json")
                                                .Build();
                    
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);
            
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // LINQ
        // Line Integrated Query
        // Lambda Functions

        /*
            This is what is helping the AppDbContext know how to create the entities themselves
            This ensures the relationships between entities are clear

            For this example, you only need to choose one entity instead of both as the modelbuilder on creation will explain the relationship between both entities
        */
        
        modelBuilder.Entity<Employee>()
            .HasOne(e => e.Department)
            .WithMany(d => d.Employees)
            .HasForeignKey(e => e.DepartmentID);

        
        // modelBuilder.Entity<Department>()
            // .HasMany(d => d.Employees)
            // .WithOne(e => e.Department)
            // .HasForeignKey(e => e.DepartmentID);

    }


}