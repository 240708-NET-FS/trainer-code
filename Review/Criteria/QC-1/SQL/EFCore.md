# Entity Framework Core

## Table of Contents

- [Entity Framework Core](#entity-framework-core)
  - [Table of Contents](#table-of-contents)
  - [What are Object/Relational Mappers?](#what-are-objectrelational-mappers)
    - [Overview](#overview)
    - [Benefits](#benefits)
    - [Why Use an ORM?](#why-use-an-orm)
  - [Intro to Entity Framework](#intro-to-entity-framework)
    - [Key Features](#key-features)
    - [Why Use Entity Framework?](#why-use-entity-framework)
  - [Entity Configuration](#entity-configuration)
    - [Data Annotations](#data-annotations)
    - [Fluent API](#fluent-api)
  - [Setup: Model \<-\> Database](#setup-model---database)
    - [DbContext](#dbcontext)
    - [Model](#model)
  - [Data First vs. Code First](#data-first-vs-code-first)
    - [What is it?](#what-is-it)
    - [When to Use](#when-to-use)
    - [Data First](#data-first)
    - [Code First](#code-first)
  - [DataContext Object](#datacontext-object)
  - [Seeding the Database](#seeding-the-database)
  - [Eager Loading](#eager-loading)
  - [Lazy Loading](#lazy-loading)

## What are Object/Relational Mappers?

### Overview

Object/Relational Mappers (ORMs) are tools that facilitate the mapping of objects in object-oriented programming to relational databases. ORMs help developers interact with databases using an object-oriented paradigm, reducing the need for complex SQL queries.

### Benefits

- **Productivity:** Simplifies database operations by allowing developers to interact with the database using their preferred programming language.
- **Maintainability:** Reduces boilerplate code and improves code readability.
- **Portability:** Abstracts database interactions, making it easier to switch between different database systems.

### Why Use an ORM?

A developer would use an ORM to streamline database operations, reduce the amount of raw SQL needed, and work more seamlessly within the object-oriented paradigm of their application. ORMs help manage data relationships, migrations, and ensure the database schema remains synchronized with the application models.

## Intro to Entity Framework

Entity Framework (EF) is an ORM framework for .NET applications. It allows developers to work with a database using .NET objects, eliminating the need for most data-access code.

### Key Features

- **Modeling:** Create and manage models based on your database schema.
- **Querying:** Use LINQ to query your database.
- **Change Tracking:** Tracks changes made to objects and synchronizes those changes with the database.
- **Migrations:** Manage schema changes over time with code-based migrations.

### Why Use Entity Framework?

Entity Framework simplifies database operations, supports rapid development, and ensures that your database schema stays in sync with your application models. It also integrates well with other .NET technologies.

[Microsoft EF Core guide.](https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli)

## Entity Configuration

Entity configuration involves defining the structure and relationships of your entities. This can be done using Data Annotations or Fluent API. Entity configuration is essential when setting up your database schema, ensuring data validation, and defining relationships between entities.

[Microsoft Entity properties docs.](https://learn.microsoft.com/en-us/ef/core/modeling/entity-properties?tabs=data-annotations%2Cwithout-nrt)

### Data Annotations

Data Annotations are attributes you can apply to your entity classes to configure how they map to the database.

```csharp
public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }

    [StringLength(50)]
    public string Address { get; set; }
}
```

### Fluent API

The Fluent API provides more advanced configuration options using the `OnModelCreating` method in your `DbContext`.

```csharp
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Student>(entity =>
    {
        entity.Property(e => e.Name).IsRequired();
        entity.Property(e => e.Address).HasMaxLength(50);
    });
}
```

## Setup: Model <-> Database

Setting up EF Core involves creating a model, defining the `DbContext`, and configuring the database connection. Setting up the model-to-database relationship is the initial step in integrating EF Core into your application. This setup allows EF Core to manage database operations based on your object models.

[Microsoft documentation on model creation for EF Core.](https://learn.microsoft.com/en-us/ef/core/modeling/)

### DbContext

The `DbContext` is the primary class for interacting with the database. It includes `DbSet` properties for each entity in your model.

```csharp
public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("your_connection_string");
    }
}
```

### Model

An example model class representing a student.

```csharp
public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}
```

Add Migration and Update Database:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## Data First vs. Code First

### What is it?

- **Data First:** Database is designed first, and the code is generated from the database schema.
- **Code First:** Code is written first, and the database schema is generated from the code.

### When to Use

- **Data First:** Use when you already have an existing database.
- **Code First:** Use when you are starting a new project and want to design your database schema through code.

### Data First

Generate models from an existing database:

```bash
dotnet ef dbcontext scaffold "your_connection_string" Microsoft.EntityFrameworkCore.SqlServer -o Models
```

[More reading on scaffolding/data-first approach.](https://learn.microsoft.com/en-us/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli)

### Code First

Define your models and let EF Core create the database schema:

```csharp
public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}
```

[This part of the "getting stated" material provided by microsoft has an example of code-first.](https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli)

## DataContext Object

The `DataContext` (or `DbContext` in EF Core) represents a session with the database and can be used to query and save instances of your entities. Use the `DbContext` for all database operations, including querying, inserting, updating, and deleting data.

```csharp
using (var context = new SchoolContext())
{
    var students = context.Students.ToList();
}
```

## Seeding the Database

Seeding the database means pre-populating it with initial data. This is useful for setting up test data or initial values required for the application. Use seeding when you need a predefined set of data in your database, such as default users, roles, or lookup values.

```csharp
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    modelBuilder.Entity<Student>().HasData(
        new Student { StudentId = 1, Name = "John Doe", Address = "123 Main St" },
        new Student { StudentId = 2, Name = "Jane Smith", Address = "456 Maple Ave" }
    );
}
```

Update the database with the seeded data:

```bash
dotnet ef migrations add SeedData
dotnet ef database update
```

## Eager Loading

Eager loading retrieves related data along with the main data in a single query. This reduces the number of queries sent to the database and improves performance. Use eager loading when you know you will need related data and want to avoid additional queries.

```csharp
var studentsWithCourses = context.Students.Include(s => s.Courses).ToList();
```

[More on eager loading.](https://learn.microsoft.com/en-us/ef/core/querying/related-data/eager)

## Lazy Loading

Lazy loading retrieves related data on demand when it is accessed. This can reduce the initial load time by not fetching unnecessary data. Use lazy loading when related data might not always be needed, thus optimizing performance by loading data only when required. The default loading behavior is lazy loading.

```csharp
public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Course> Courses { get; set; }
}
```

Enable lazy loading in `DbContext`:

```csharp
public class SchoolContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseLazyLoadingProxies().UseSqlServer("your_connection_string");
    }
}
```

[More on lazy loading.](https://learn.microsoft.com/en-us/ef/core/querying/related-data/lazy)
