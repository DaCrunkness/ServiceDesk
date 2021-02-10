CREATE TABLE [dbo].[Users]
(
    [FirstName] NVARCHAR(256) NOT NULL, 
    [LastName] NVARCHAR(256) NOT NULL,
    [PhoneNumber] NVARCHAR(256) NOT NULL,
    [EmailAddress] NVARCHAR(256) NOT NULL PRIMARY KEY UNIQUE,
    [UsersGroup] NVARCHAR(256) NOT NULL,
    [CreatedDate] DATETIME2 NOT NULL DEFAULT getutcdate() 
)
