CREATE TABLE [dbo].[Errors]
(
	[Code] INT NOT NULL PRIMARY KEY UNIQUE, 
    [Type] NCHAR(10) NOT NULL, 
    [Phrase] NVARCHAR(50) NOT NULL, 
    [Detail] NVARCHAR(250) NOT NULL,
    [CanAutoAssign] NCHAR(1) NOT NULL
)
