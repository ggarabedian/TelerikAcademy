-- Choose a test database in which to create the table
-- Task 01. Create a table in SQL Server with 10 000 000 log entries (date + text). 
-- Search in the table by date range. Check the speed (without caching).                               
CHECKPOINT; 
DBCC DROPCLEANBUFFERS;
DBCC FREEPROCCACHE;

GO

CREATE TABLE Logs(
	LogId int NOT NULL PRIMARY KEY IDENTITY,
	Content nvarchar(100),
	LogDate date
)
GO

INSERT INTO Logs(Content, LogDate) VALUES ('All is well', GETDATE() + 1)
INSERT INTO Logs(Content, LogDate) VALUES ('Error found', GETDATE() + 2)
INSERT INTO Logs(Content, LogDate) VALUES ('Tracking bug', GETDATE() + 3)
INSERT INTO Logs(Content, LogDate) VALUES ('Connection problem', GETDATE() + 4)
INSERT INTO Logs(Content, LogDate) VALUES ('Tired of logging', GETDATE() + 5)
INSERT INTO Logs(Content, LogDate) VALUES ('I quit', GETDATE() + 6)

GO

DECLARE @counter int = 0
WHILE (SELECT COUNT(*) FROM Logs) < 1000000
BEGIN
	INSERT INTO Logs(Content, LogDate)
	SELECT Content + CONVERT(varchar, @counter), GETDATE() + @counter FROM Logs
	SET @counter = @counter + 1
END
GO

-- Task 02. Add an index to speed-up the search by date. Test the search speed (after cleaning the cache).                               
CREATE INDEX IDX_Logs_LogDate
ON Logs(LogDate)

CHECKPOINT; 
DBCC DROPCLEANBUFFERS;
DBCC FREEPROCCACHE;

GO

SELECT * FROM Logs
WHERE LogDate BETWEEN GETDATE() AND GETDATE() + 10

-- Elapsed Time: 00:00:05


-- Task 03. Add a full text index for the text column. Try to search with and without the full-text index and compare the speed.                              
CREATE FULLTEXT CATALOG LogsContentCatalog
WITH ACCENT_SENSITIVITY = OFF

CREATE FULLTEXT INDEX ON Logs(Content)
KEY INDEX PK_Logs_5E5486488F4AE95D
ON LogsContentCatalog
WITH CHANGE_TRACKING AUTO

-- Searching without full-text index. Might need to be added manually
CHECKPOINT; 
DBCC DROPCLEANBUFFERS;
DBCC FREEPROCCACHE;

GO

SELECT * FROM Logs
WHERE Content LIKE 'Connection%'
GO

-- Elapsed Time: 00:00:06

CHECKPOINT; 
DBCC DROPCLEANBUFFERS;
DBCC FREEPROCCACHE;

GO

SELECT * FROM Logs
WHERE Content LIKE 'Error%'
GO

-- Elapsed Time: 00:00:06

-- Searching with full-text index
CHECKPOINT; 
DBCC DROPCLEANBUFFERS;
DBCC FREEPROCCACHE;

GO

SELECT * FROM Logs
WHERE CONTAINS(Content, 'Connection')
GO

-- Elapsed Time: 00:00:04

CHECKPOINT; 
DBCC DROPCLEANBUFFERS;
DBCC FREEPROCCACHE;

GO

SELECT * FROM Logs
WHERE CONTAINS(Content, 'Error')
GO

-- Elapsed Time: 00:00:05