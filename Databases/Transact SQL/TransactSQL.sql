USE master

GO

--Task 01. Create a database with two tables: Persons(Id(PK), FirstName, LastName, SSN) and Accounts(Id(PK), 
--PersonId(FK), Balance). Insert few records for testing.
--Write a stored procedure that selects the full names of all persons.

CREATE DATABASE PersonalAccounts

GO

Use PersonalAccounts

GO

CREATE TABLE Persons(
	Id int IDENTITY NOT NULL PRIMARY KEY,
	FirstName nvarchar(40) NOT NULL,
	LastName nvarchar(40) NOT NULL,
	SSN nvarchar(20) NOT NULL
)

GO

CREATE TABLE Accounts(
	Id int IDENTITY NOT NULL PRIMARY KEY,
	PersonId int NOT NULL FOREIGN KEY REFERENCES Persons(Id),
	Balance money NOT NULL
)

GO

DECLARE @counter int
SET @counter = 1
WHILE @counter < 10
	BEGIN
		INSERT INTO Persons(FirstName, LastName, SSN)
		VALUES(
			'John' + CAST(@counter AS nvarchar(2)),
			'Doe' + CAST(@counter AS nvarchar(2)),
			'00000000' + CAST(@counter AS nvarchar(2)))

		INSERT INTO Accounts(PersonId, Balance)
		VALUES(
			@counter,
			100000 / @counter + 10500 * @counter)
		SET @counter = @counter + 1
	END

GO

--Task 02. Create a stored procedure that accepts a number as a parameter and returns all persons who 
--have more money in their accounts than the supplied number.

CREATE PROC dbo.usp_SelectPeopleWithMoneyMoreThan(@moneyAmount money = 50000)
	AS
		SELECT p.FirstName + ' ' + p.LastName AS [Full Name], a.Balance
		FROM Persons p
			JOIN Accounts a
				ON p.Id = a.PersonId
		WHERE a.Balance > @moneyAmount

GO

EXEC usp_SelectPeopleWithMoneyMoreThan 70000

GO

--Task 03. Create a function that accepts as parameters – sum, yearly interest rate and number of months.
--It should calculate and return the new sum.
--Write a SELECT to test whether the function works as expected.

USE PersonalAccounts
GO
CREATE FUNCTION ufn_YearlyInterestCalculator(@sum money, @interestRate float, @numberOfMonths int)
	RETURNS money
	AS
		BEGIN
			RETURN @sum * (1 + @interestRate / 12) * @numberOfMonths
		END

GO

SELECT Balance, dbo.ufn_YearlyInterestCalculator(Balance, 0.75, 1) AS [Interest]
FROM Accounts

GO
--Task 04. Create a stored procedure that uses the function from the previous example to give an 
--interest to a person's account for one month. 
--It should take the AccountId and the interest rate as parameters.

CREATE PROC dbo.usp_IncrementBalanceWithOneYearInterest(@accountId int, @interestRate float)
	AS
		DECLARE @balance money
		SELECT @balance = Balance FROM Accounts WHERE Id = @accountId

		DECLARE @updatedBalance money
		SELECT @updatedBalance = dbo.ufn_YearlyInterestCalculator(@balance, @interestRate, 1)

		SELECT p.FirstName + ' ' + p.LastName AS [Full Name], 
		a.Balance AS [Original Balance],
		@updatedBalance AS [Updated Balance]
		FROM Persons p
			JOIN Accounts a
				ON p.Id = a.PersonId
		WHERE a.Id = @accountId

GO

EXEC dbo.usp_IncrementBalanceWithOneYearInterest 1, 0.5

GO

--Task 05. Add two more stored procedures WithdrawMoney(AccountId, money) and 
--DepositMoney(AccountId, money) that operate in transactions.

CREATE PROC dbo.usp_WithdrawMoney(@accountId int, @money float)
	AS
		BEGIN TRAN
			UPDATE Accounts
			SET Balance -= @money
			WHERE Id = @accountId
		COMMIT TRAN
GO

CREATE PROCEDURE dbo.usp_DepositMoney(@accountId int, @money money)
	AS
		BEGIN TRAN
			UPDATE Accounts
			SET Balance += @money
			WHERE Id = @accountId
		COMMIT TRAN
GO

EXEC dbo.usp_WithdrawMoney 1, 10000

EXEC dbo.usp_DepositMoney 2, 20000

GO

--Task 06. Create another table – Logs(LogID, AccountID, OldSum, NewSum).
--Add a trigger to the Accounts table that enters a new entry into the Logs table every 
--time the sum on an account changes.

CREATE TABLE Logs(
	Id int IDENTITY NOT NULL PRIMARY KEY,
	AccountId int NOT NULL FOREIGN KEY REFERENCES Accounts(Id),
	OldSum money NOT NULL,
	NewSUm money NOT NULL)

GO

CREATE TRIGGER tr_OnBalanceChange ON Accounts FOR UPDATE
	AS
		DECLARE @oldSum money;
		SELECT @oldSum = Balance FROM deleted;

		INSERT INTO Logs(AccountId, OldSum, NewSum)
        SELECT Id, @oldSum, Balance
        FROM inserted
GO

EXEC dbo.usp_WithdrawMoney 1, 10000

EXEC dbo.usp_DepositMoney 2, 20000

GO

--Task 07. Define a function in the database TelerikAcademy that returns all 
--Employee's names (first or middle or last name) and all town's names that are 
--comprised of given set of letters.
--Example: 'oistmiahf' will return 'Sofia', 'Smith', … but not 'Rob' and 'Guy'.

Use TelerikAcademy

GO

CREATE FUNCTION ufn_SearchForWordsPattern(@pattern nvarchar(100))
	RETURNS @NamesFound TABLE (Name nvarchar(100))
AS
BEGIN
	INSERT @NamesFound
	SELECT * 
	FROM
		(SELECT e.FirstName FROM Employees e
        UNION
        SELECT e.LastName FROM Employees e
        UNION 
        SELECT t.Name FROM Towns t) as temp(AllNames)
    WHERE PATINDEX ('%[^' + @pattern + ']%', AllNames) = 0
	RETURN
END

GO

SELECT * FROM dbo.ufn_SearchForWordsPattern('oistmiahf')

GO

--Task 08. Using database cursor write a T-SQL script that scans all employees and 
--their addresses and prints all pairs of employees that live in the same town.

DECLARE empCursor CURSOR READ_ONLY FOR
    SELECT e1.FirstName, e1.LastName, t1.Name, e2.FirstName, e2.LastName
    FROM Employees e1
    JOIN Addresses a1
        ON e1.AddressId = a1.AddressId
    JOIN Towns t1
        ON a1.TownId = t1.TownId,
        Employees e2
    JOIN Addresses a2
        ON e2.AddressId = a2.AddressId
    JOIN Towns t2
        ON a2.TownId = t2.TownId
    WHERE t1.TownId = t2.TownId AND e1.EmployeeId != e2.EmployeeId
    ORDER BY e1.FirstName, e2.FirstName

OPEN empCursor
DECLARE @firstName1 nvarchar(50), 
        @lastName1 nvarchar(50),
        @townName nvarchar(50),
        @firstName2 nvarchar(50),
        @lastName2 nvarchar(50)
FETCH NEXT FROM empCursor INTO @firstName1, @lastName1, @townName, @firstName2, @lastName2

WHILE @@FETCH_STATUS = 0
	BEGIN
		PRINT @firstName1 + ' ' + @lastName1 + 
			  ' <==> ' + @townName + ' <==> ' +
			  @firstName2 + ' ' + @lastName2;

		FETCH NEXT FROM empCursor 
		INTO @firstName1, @lastName1, @townName, @firstName2, @lastName2
	END
CLOSE empCursor
DEALLOCATE empCursor