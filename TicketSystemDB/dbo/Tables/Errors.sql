CREATE TABLE [dbo].[Errors]
(
	[Code] INT NOT NULL PRIMARY KEY UNIQUE,
    [Type] NCHAR(50) NOT NULL, 
    [Phrase] NVARCHAR(50) NOT NULL, 
    [Message] NVARCHAR(250) NOT NULL,
    [WillAutoAssign] NCHAR(16) NOT NULL
)
