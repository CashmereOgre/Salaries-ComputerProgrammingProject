CREATE TABLE [dbo].[Table]
(
	[WorkerID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Surname] NVARCHAR(50) NOT NULL, 
    [DateOfBirth] DATE NOT NULL, 
    [Gender] NCHAR(10) NOT NULL 
)
