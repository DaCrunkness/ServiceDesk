CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,  
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL,
    [PhoneNumber] NVARCHAR(50) NOT NULL,
    [EmailAddress] NVARCHAR(256) NOT NULL, 
    [CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate() 
)
