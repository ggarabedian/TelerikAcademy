USE TelerikAcademy

--Task 1. SQL (Structured Query Language) is a standard interactive and programming language for 
--obtaining information from and updating a database using queries. Queries take the form of a command 
--language that lets you select, insert, update and delete data.

--Task 2. T-SQL (Transact SQL) is an extension to the standard SQL language. T-SQL is the standard 
--language used in MS SQL Server and supports if statements, loops and exceptions.

--Task 4. Write a SQL query to find all information about all departments.

SELECT *
FROM [Departments]

--Task 5. Write a SQL query to find all department names.

SELECT Name
FROM [Departments]

--Task 6. Write a SQL query to find the salary of each employee.

SELECT FirstName, LastName, Salary
FROM [Employees]

--Task 7. Write a SQL to find the full name of each employee.

SELECT FirstName + ' ' + LastName AS 'FullName'
FROM [Employees]

--Task 8. Write a SQL query to find the email addresses of each employee (by his first and last name). 
--Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". 
--The produced column should be named "Full Email Addresses".

SELECT FirstName + '.' + LastName + '@telerik.com' AS 'Full Email Addresses'
FROM [Employees]

--Task 9. Write a SQL query to find all different employee salaries.

SELECT DISTINCT Salary
FROM [Employees]

--Task 10. Write a SQL query to find all information about the employees whose job title is 
--“Sales Representative“.

SELECT *
FROM [Employees]
WHERE JobTitle = 'Sales Representative'

--Task 11. Write a SQL query to find the names of all employees whose first name starts with "SA".

SELECT *
FROM [Employees]
WHERE FirstName LIKE 'SA%'

--Task 12. Write a SQL query to find the names of all employees whose last name contains "ei".

SELECT *
FROM [Employees]
WHERE LastName LIKE '%ei%'

--Task 13. Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].

SELECT FirstName, LastName, Salary
FROM [Employees]
WHERE Salary BETWEEN 20000 AND 30000

--Task 14. Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.

SELECT FirstName, LastName, Salary
FROM [Employees]
WHERE Salary IN (12500, 14000, 23600, 25000)

--Task 15. Write a SQL query to find all employees that do not have manager.

SELECT FirstName, LastName, ManagerID
FROM [Employees]
WHERE ManagerID IS NULL

--Task 16. Write a SQL query to find all employees that have salary more than 50000. 
--Order them in decreasing order by salary.

SELECT FirstName, LastName, Salary
FROM [Employees]
WHERE Salary > 50000
ORDER BY Salary DESC

--Task 17. Write a SQL query to find the top 5 best paid employees.

SELECT TOP 5 FirstName, LastName, Salary
FROM [Employees]
ORDER BY Salary DESC

--Task 18. Write a SQL query to find all employees along with their address. Use inner join with ON clause.

SELECT empl.FirstName + ' ' + empl.LastName, addr.AddressText
FROM [Employees] empl
	INNER JOIN [Addresses] addr
		ON empl.AddressID = addr.AddressID

--Task 19. Write a SQL query to find all employees and their address. 
--Use equijoins (conditions in the WHERE clause).

SELECT empl.FirstName + ' ' + empl.LastName, addr.AddressText
FROM [Employees] empl, [Addresses] addr
WHERE empl.AddressID = addr.AddressID

--Task 20. Write a SQL query to find all employees along with their manager.

SELECT e.FirstName + ' ' + e.LastName AS 'Employee name', 
	   m.FirstName + ' ' + m.LastName AS 'Manager name'
FROM [Employees] e
	INNER JOIN [Employees] m
		ON e.ManagerID = m.EmployeeID

--Task 21. Write a SQL query to find all employees, along with their manager and their address. 
--Join the 3 tables: Employees e, Employees m and Addresses a.

SELECT e.FirstName + ' ' + e.LastName AS 'Employee name', 
	   a.AddressText AS 'Employee address',
	   m.FirstName + ' ' + m.LastName AS 'Manager name'
	   
FROM [Employees] e
	INNER JOIN [Employees] m
		ON e.ManagerID = m.EmployeeID
			INNER JOIN [Addresses] a
				ON e.AddressID = a.AddressID

--Task 22. Write a SQL query to find all departments and all town names as a single list. Use UNION.

SELECT d.Name
FROM [Departments] d
UNION 
SELECT t.Name
FROM [Towns] t

--Task 23. Write a SQL query to find all the employees and the manager for each of them along with 
--the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.

SELECT e.FirstName + ' ' + e.LastName AS 'Employee name', 
	   m.FirstName + ' ' + m.LastName AS 'Manager name'
FROM [Employees] m
	RIGHT OUTER JOIN [Employees] e
		ON e.ManagerID = m.EmployeeID

SELECT e.FirstName + ' ' + e.LastName AS 'Employee name', 
	   m.FirstName + ' ' + m.LastName AS 'Manager name'
FROM [Employees] e
	LEFT OUTER JOIN [Employees] m
		ON e.ManagerID = m.EmployeeID

--Task 24. Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" 
--whose hire year is between 1995 and 2005.

SELECT e.FirstName + ' ' + e.LastName AS 'Employee name', d.Name, e.HireDate	   
FROM [Employees] e, [Departments] d
WHERE e.DepartmentID = d.DepartmentID 
	AND d.Name IN ('Sales', 'Finance')
	AND e.HireDate BETWEEN '1995-01-01 00:00:00' AND '2005-01-01 00:00:00'