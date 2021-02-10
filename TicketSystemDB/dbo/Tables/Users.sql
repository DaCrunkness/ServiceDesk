CREATE TABLE [dbo].[Users]
(
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL,
    [PhoneNumber] NVARCHAR(50) NOT NULL,
    [EmailAddress] NVARCHAR(256) NOT NULL PRIMARY KEY UNIQUE,
    [Group] NVARCHAR(50) NOT NULL,
    [CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate() 
)
