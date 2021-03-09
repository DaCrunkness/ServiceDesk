CREATE TABLE [dbo].[Tickets]
(
    [TicketNumber] NVARCHAR(256) NOT NULL PRIMARY KEY UNIQUE, 
    [Creator] NVARCHAR(256) NOT NULL, 
    [UsersGroup] NVARCHAR(256) NOT NULL,
    [Type] NVARCHAR(256) NOT NULL, 
    [Status] NVARCHAR(256) NOT NULL DEFAULT 'Open', 
    [Summary] NVARCHAR(500) NOT NULL, 
    [Detail] NVARCHAR(MAX) NOT NULL, 
    [CreateDate] DATETIME2 NOT NULL DEFAULT getutcdate(), 
    [LastModified] NVARCHAR(256) NOT NULL DEFAULT 'Now',
    [HasAttachment] NVARCHAR(256) NOT NULL DEFAULT 'false',
    [WillAutoAssign] NVARCHAR(256) NOT NULL DEFAULT 'false',
    [IsAssigned] NVARCHAR(256) NOT NULL DEFAULT 'false',
    [IsResolved] NVARCHAR(256) NOT NULL DEFAULT 'false',
    [AssignedTo] NVARCHAR(256) NOT NULL DEFAULT 'None',
    [AssignedBy] NVARCHAR(256) NOT NULL DEFAULT 'System'
)
