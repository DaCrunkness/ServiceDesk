CREATE PROCEDURE [dbo].[spTickets_LoadByType]
	@Type NVARCHAR(256)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT TicketNumber, Creator, Summary, Detail, CreateDate
		From [dbo].[Tickets]
		WHERE [Type] = @Type
END
