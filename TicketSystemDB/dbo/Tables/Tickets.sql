CREATE TABLE [dbo].[Tickets]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [TicketNumber] INT NOT NULL, 
    [Creator] NVARCHAR(128) NOT NULL, 
    [Summary] NVARCHAR(500) NOT NULL, 
    [Detail] NVARCHAR(MAX) NOT NULL, 
    [Attachment] BINARY(50),
    [CreateDate] DATETIME2 NOT NULL DEFAULT getutcdate()
)
