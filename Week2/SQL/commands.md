1. **Create Tables with Keys and Constraints:**
    
    ```sql
    CREATE TABLE Departments (
        DepartmentID INT PRIMARY KEY,
        DepartmentName VARCHAR(100) NOT NULL
    );
    
    CREATE TABLE Employees (
        EmployeeID INT PRIMARY KEY IDENTITY(1,1),
        FirstName VARCHAR(50) NOT NULL,
        LastName VARCHAR(50) NOT NULL,
        DepartmentID INT,
        Email VARCHAR(100) UNIQUE,
        CONSTRAINT FK_Department FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
    );
    
    CREATE TABLE ProjectAssignments (
        ProjectID INT,
        EmployeeID INT,
        AssignmentDate DATE,
        PRIMARY KEY (ProjectID, EmployeeID),
        CONSTRAINT FK_Employee FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
    );
    
    ```
    
2. **Insert Initial Data:**
    
    ```sql
    INSERT INTO Departments (DepartmentID, DepartmentName) VALUES (1, 'Engineering'), (2, 'HR');
    
    INSERT INTO Employees (FirstName, LastName, DepartmentID, Email)
    VALUES ('John', 'Doe', 1, 'john.doe@example.com'),
           ('Jane', 'Smith', 2, 'jane.smith@example.com');
    
    ```

3. **DDL Operations:**
    
    ```sql
    -- Create a new table
    CREATE TABLE Projects (
        ProjectID INT PRIMARY KEY,
        ProjectName VARCHAR(100) NOT NULL
    );
    
    -- Add a new column
    ALTER TABLE Employees ADD PhoneNumber VARCHAR(15);
    
    -- Drop a column
    ALTER TABLE Employees DROP COLUMN PhoneNumber;
    
    -- Truncate a table
    TRUNCATE TABLE ProjectAssignments;
    
    ```
    
4. **DML Operations:**
    
    ```sql
    -- Insert data
    INSERT INTO Projects (ProjectID, ProjectName) VALUES (1, 'New Project');
    
    -- Update data
    UPDATE Employees SET Email = 'john.newemail@example.com' WHERE EmployeeID = 1;
    
    -- Delete data
    DELETE FROM Projects WHERE ProjectID = 1;
    
    ```
    
5. **DQL Operations:**
    
    ```sql
    -- Select with aggregate functions
    SELECT DepartmentID, COUNT(*) AS EmployeeCount
    FROM Employees
    GROUP BY DepartmentID;
    
    -- Subquery
    SELECT FirstName, LastName
    FROM Employees
    WHERE DepartmentID = (SELECT DepartmentID FROM Departments WHERE DepartmentName = 'HR');
    
    -- Join
    SELECT e.FirstName, e.LastName, d.DepartmentName
    FROM Employees e
    JOIN Departments d ON e.DepartmentID = d.DepartmentID;
    
    ```