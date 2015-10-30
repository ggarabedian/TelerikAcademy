USE TelerikAcademy

--Task 01. Write a SQL query to find the names and salaries of the employees that take the minimal 
--salary in the company. Use a nested SELECT statement.

SELECT FirstName + ' ' + LastName AS 'Full Name', Salary
FROM Employees
WHERE Salary = 
	(SELECT MIN(Salary) FROM Employees)

--Task 02. Write a SQL query to find the names and salaries of the employees that have a salary 
--that is up to 10% higher than the minimal salary for the company.

SELECT FirstName + ' ' + LastName AS 'Full Name', Salary
FROM Employees
WHERE Salary < 
	(SELECT MIN(Salary) * 1.1 FROM Employees)

--Task 03. Write a SQL query to find the full name, salary and department of the employees that 
--take the minimal salary in their department. Use a nested SELECT statement.

SELECT e.FirstName + ' ' + e.LastName AS 'Full Name', e.Salary, e.DepartmentID, d.Name
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE Salary = 
	(SELECT MAX(Salary) FROM Employees
	 WHERE DepartmentID = e.DepartmentID)

--Task 04. Write a SQL query to find the average salary in the department #1.

SELECT AVG(Salary) AS 'Average Salary'
FROM Employees e
WHERE e.DepartmentID = 1

--Task 05. Write a SQL query to find the average salary in the "Sales" department.

SELECT AVG(Salary) AS 'Average Salary'
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

--Task 06. Write a SQL query to find the number of employees in the "Sales" department.

SELECT Count(*) AS 'Employees count'
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
WHERE d.Name = 'Sales'

--Task 07. Write a SQL query to find the number of all employees that have manager.

SELECT Count(*) AS 'Employees with manager count'
FROM Employees e
WHERE e.ManagerID IS NOT NULL

--Task 08. Write a SQL query to find the number of all employees that have no manager.

SELECT Count(*) AS 'Employees with manager count'
FROM Employees e
WHERE e.ManagerID IS NULL

--Task 09. Write a SQL query to find all departments and the average salary for each of them.

SELECT d.Name, AVG(Salary) AS 'Average Salary'
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY d.Name

--Task 10. Write a SQL query to find the count of all employees in each department and for each town.

SELECT d.Name, t.Name, Count(e.EmployeeID) AS 'Employees count'
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
	JOIN Addresses a
		ON e.AddressID = a.AddressID
	JOIN Towns t
		ON a.TownID = t.TownID
GROUP BY d.Name, t.Name

--Task 11. Write a SQL query to find all managers that have exactly 5 employees. 
--Display their first name and last name.

SELECT e.EmployeeID AS 'Manager ID',
	   e.FirstName + ' ' + e.LastName AS 'Manager Full Name',
	   COUNT(e.EmployeeID) AS 'Employees Count'
	FROM Employees e
		JOIN Employees empl
			ON empl.ManagerID = e.EmployeeID
	GROUP BY e.EmployeeID, e.FirstName, e.LastName
	HAVING COUNT(e.EmployeeID) = 5

--Task 12. Write a SQL query to find all employees along with their managers. 
--For employees that do not have manager display the value "(no manager)".

SELECT e.FirstName + ' ' + e.LastName AS 'Employee Full Name',
	   COALESCE(empl.FirstName +' ' + empl.LastName, 'no manager') AS 'Manager Full Name'
	FROM Employees e
		LEFT JOIN Employees empl
			ON e.ManagerID = empl.EmployeeID

--Task 13. Write a SQL query to find the names of all employees whose last name is 
--exactly 5 characters long. Use the built-in LEN(str) function.

SELECT LastName
FROM Employees
WHERE LEN(LastName) = 5

--Task 14. Write a SQL query to display the current date and time in the following format 
--"day.month.year hour:minutes:seconds:milliseconds".
--Search in Google to find how to format dates in SQL Server.

SELECT CONVERT(VARCHAR(24),GETDATE(),113)

--Task 15. Write a SQL statement to create a table Users. Users should have username, password, 
--full name and last login time.
--Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
--Define the primary key column as identity to facilitate inserting records.
--Define unique constraint to avoid repeating usernames.
--Define a check constraint to ensure the password is at least 5 characters long.

CREATE TABLE Users (
	UserID int IDENTITY,
	CONSTRAINT PK_Users PRIMARY KEY(UserID),
	UserName nvarchar(100) NOT NULL CHECK (LEN(Username) > 5) UNIQUE,
	Pass nvarchar(100) NOT NULL CHECK (LEN(Pass) > 5),
	FullName nvarchar(100) NOT NULL,
	LastLoginTime datetime NULL
	)

GO

--TASK 16: Write a SQL statement to create a view that displays the users from the Users table 
--that have been in the system today. Test if the view works correctly.

CREATE VIEW [Logged Users Today] AS 
	SELECT Username FROM Users
	WHERE DATEDIFF(DAY, LastLoginTime, GETDATE()) = 0
    
GO

--TASK 17: Write a SQL statement to create a table Groups. Groups should have unique name 
--(use unique constraint). Define primary key and identity column.

CREATE TABLE Groups (
	GroupID int IDENTITY,
	CONSTRAINT PK_Groups PRIMARY KEY(GroupID),
	Name nvarchar(100) NOT NULL UNIQUE
)
    
GO

--TASK 18: Write a SQL statement to add a column GroupID to the table Users.
--Fill some data in this new column and as well in the `Groups table.
--Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.

ALTER TABLE Users 
	ADD GroupID int NULL
    
GO

ALTER TABLE Users
	ADD CONSTRAINT FK_Users_Groups
	FOREIGN KEY (GroupId)
	REFERENCES Groups(GroupId)

GO

--TASK 19: Write SQL statements to insert several records in the Users and Groups tables.

INSERT INTO Groups VALUES 
	('Crazy People'),
	('Odd People'),
	('Smart People'),
	('Happy People'),
	('Funny People')

INSERT INTO Users VALUES
    ('JohnDoe1', '123456', 'DoeJohn1', '2015-5-09 00:00:00', 1),
    ('JohnDoe2', '123456', 'DoeJohn2', '2015-6-08 00:00:00', 2),
    ('JohnDoe3', '123456', 'DoeJohn3', '2015-7-07 00:00:00', 3),
    ('JohnDoe4', '123456', 'DoeJohn4', '2015-8-06 00:00:00', 4),
    ('JohnDoe5', '123456', 'DoeJohn5', '2015-9-15 00:00:00', 5),
	('JohnDoe6', '123456', 'DoeJohn6', '2015-9-15 00:00:00', 1)

GO

--TASK 20: Write SQL statements to update some of the records in the Users and Groups tables.

UPDATE Users 
	SET UserName='JaneDoe1', FullName='DoeJane1'
	WHERE Username = 'JohnDoe1'

UPDATE Groups 
	SET Name='Not-So-Crazy People'
	WHERE Name = 'Crazy People'

GO

--TASK 21: Write SQL statements to delete some of the records from the Users and Groups tables.

DELETE FROM Users
    WHERE UserID = 5

DELETE FROM Groups
    WHERE GroupId = 5

GO

--TASK 22: Write SQL statements to insert in the Users table the names of all employees from the Employees table.
--Combine the first and last names as a full name.
--For username use the first letter of the first name + the last name (in lowercase).
--Use the same for the password, and NULL for last login time.

INSERT INTO Users(UserName, Pass, FullName, LastLoginTime)
	SELECT CONCAT(FirstName, LOWER(LastName)),
		   CONCAT(FirstName, LOWER(LastName)),
		   CONCAT(FirstName, LastName),
		   NULL
	FROM Employees

GO

--TASK 23: Write a SQL statement that changes the password to NULL for all users that have 
--not been in the system since 10.03.2010.

UPDATE Users
    SET Pass = NULL
    WHERE DATEDIFF(day, LastLoginTime, '2010-3-10 00:00:00') > 0

GO

--TASK 24: Write a SQL statement that changes the password to NULL for all users that have 
--not been in the system since 10.03.2010.

DELETE
    FROM Users
    WHERE Pass IS NULL

GO

--TASK 25: Write a SQL query to display the average employee salary by department and job title.

SELECT AVG(e.Salary) AS [Average Salary],
		   e.JobTitle, 
		   d.Name AS [Department Name]
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY e.JobTitle, d.Name
ORDER BY 'Average Salary'

GO

--TASK 26: Write a SQL query to display the minimal employee salary by department and job title along 
--with the name of some of the employees that take it.

SELECT MIN(e.Salary) AS [Average Salary],
		   e.JobTitle, 
		   d.Name AS [Department Name],
		   MIN(e.FirstName + ' ' + e.LastName) AS [Employee Full Name]
FROM Employees e
	JOIN Departments d
		ON e.DepartmentID = d.DepartmentID
GROUP BY e.JobTitle, d.Name
ORDER BY 'Average Salary'

GO

--TASK 27: Write a SQL query to display the town where maximal number of employees work.

SELECT TOP 1 t.Name AS [Town], COUNT(e.EmployeeID) as [Employees Count]
    FROM Employees e 
    JOIN Addresses a
        ON e.AddressID = a.AddressID
    JOIN Towns t
        ON t.TownID = a.TownID
    GROUP BY t.Name
    ORDER BY 'Employees Count' DESC

GO

--TASK 28: Write a SQL query to display the number of managers from each town.

SELECT t.Name AS [Town], COUNT(e.EmployeeID) as 'Managers Count'
    FROM Employees e 
    JOIN Addresses a
        ON e.AddressID = a.AddressID
    JOIN Towns t
        ON t.TownID = a.TownID
    GROUP BY t.Name
    ORDER BY 'Managers Count' DESC

GO

--TASK 29: Write a SQL to create table WorkHours to store work reports for each employee 
--(employee id, date, task, hours, comments).
--Don't forget to define identity, primary key and appropriate foreign key.
--Issue few SQL statements to insert, update and delete of some data in the table.
--Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.
--For each change keep the old record data, the new record data and the command (insert / update / delete).

CREATE TABLE WorkHours (
    WorkReportId int IDENTITY,
    EmployeeId Int NOT NULL,
    OnDate DATETIME NOT NULL,
    Task nvarchar(256) NOT NULL,
    WorkHours Int NOT NULL,
    Comments nvarchar(256),
    CONSTRAINT PK_Id PRIMARY KEY(WorkReportId),
    CONSTRAINT FK_Employees_WorkHours 
        FOREIGN KEY (EmployeeId)
        REFERENCES Employees(EmployeeId)
) 

GO

DECLARE @counter int;
SET @counter = 20;
WHILE @counter > 0
BEGIN
    INSERT INTO WorkHours(EmployeeId, OnDate, Task, WorkHours)
    VALUES (@counter, GETDATE(), 'TASK: ' + CONVERT(varchar(10), @counter), @counter)
    SET @counter = @counter - 1
END

UPDATE WorkHours
    SET Comments = 'Working like a slave'
    WHERE WorkHours > 10

DELETE
    FROM WorkHours
    WHERE EmployeeId IN (2, 5, 11)

CREATE TABLE WorkHoursLogs (
    WorkLogId int,
    EmployeeId Int NOT NULL,
    OnDate DATETIME NOT NULL,
    Task nvarchar(256) NOT NULL,
    WorkHours Int NOT NULL,
    Comments nvarchar(256),
    [Action] nvarchar(50) NOT NULL,
    CONSTRAINT FK_Employees_WorkHoursLogs
        FOREIGN KEY (EmployeeId)
        REFERENCES Employees(EmployeeId),
    CONSTRAINT [CC_WorkReportsLogs] CHECK ([Action] IN ('Insert', 'Delete', 'DeleteUpdate', 'InsertUpdate'))
) 

GO

--TASK 30: Start a database transaction, delete all employees from the 'Sales' department 
--along with all dependent records from the pother tables. At the end rollback the transaction.

BEGIN TRANSACTION

    ALTER TABLE Departments
        DROP CONSTRAINT FK_Departments_Employees
    GO

    DELETE e
        FROM Employees e
			JOIN Departments d
				ON e.DepartmentID = d.DepartmentID
        WHERE d.Name = 'Sales'

ROLLBACK TRANSACTION

--TASK 31: Start a database transaction and drop the table EmployeesProjects.
--Now how you could restore back the lost table data?

BEGIN TRANSACTION

    DROP TABLE EmployeesProjects

ROLLBACK TRANSACTION

--TASK 32: Find how to use temporary tables in SQL Server.
--Using temporary tables backup all records from EmployeesProjects and restore them back after 
--dropping and re-creating the table.

BEGIN TRANSACTION

    SELECT * 
        INTO #EmployeesProjectsTemp  --- Create new table
        FROM EmployeesProjects

    DROP TABLE EmployeesProjects

    SELECT * 
        INTO EmployeesProjects --- Create new table
        FROM #EmployeesProjectsTemp

    DROP TABLE #EmployeesProjectsTemp

ROLLBACK TRANSACTION