CREATE PROCEDURE [dbo].[spSubmitTicket]
	@TicketNumber NVARCHAR(256),
	@Creator NVARCHAR(256), 
	@UsersGroup NVARCHAR(256), 
	@Type NVARCHAR(256),
	@Summary NVARCHAR(500),
	@Detail NVARCHAR(max),
	@LastModified NVARCHAR(256)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO  dbo.Tickets ([TicketNumber], [Creator], [UsersGroup], [Type], [Summary], [Detail], [LastModified])
                                         values (@TicketNumber, @Creator, @UsersGroup, @Type, @Summary, @Detail, @LastModified);
END