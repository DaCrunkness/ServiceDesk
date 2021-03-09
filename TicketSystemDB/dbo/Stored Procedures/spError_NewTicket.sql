CREATE PROCEDURE [dbo].[spError_NewTicket]
	@TicketNumber NVARCHAR(256),
	@Creator NVARCHAR(256), 
	@UsersGroup NVARCHAR(256), 
	@Type NVARCHAR(256),
	@Status NVARCHAR(256),
	@Summary NVARCHAR(500),
	@Detail NVARCHAR(max),
	@LastModified NVARCHAR(256)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO  dbo.Tickets ([TicketNumber], [Creator], [UsersGroup], [Type], [Status], [Summary], [Detail], [LastModified])
                                         values (@TicketNumber, @Creator, @UsersGroup, @Type, @Status, @Summary, @Detail, @LastModified);
END