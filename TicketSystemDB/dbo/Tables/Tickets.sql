CREATE TABLE [dbo].[Tickets]
(
    [TicketNumber] INT NOT NULL PRIMARY KEY UNIQUE, 
    [Creator] NVARCHAR(128) NOT NULL, 
    [Type] NVARCHAR(50) NOT NULL, 
    [HasAttachment] NCHAR(10) NOT NULL,
    [UsersGroup] NVARCHAR(50) NOT NULL, 
    [Summary] NVARCHAR(500) NOT NULL, 
    [Detail] NVARCHAR(MAX) NOT NULL, 
    [CreateDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [LastModified] NVARCHAR(50) NOT NULL
)
