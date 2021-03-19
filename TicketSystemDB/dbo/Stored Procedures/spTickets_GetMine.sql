CREATE PROCEDURE [dbo].[spTickets_GetMine]
	@Creator NVARCHAR(256)

AS
BEGIN
	SET NOCOUNT ON;

	SELECT TicketNumber, Creator, Summary, Detail, CreateDate
		From [dbo].[Tickets]
		Where Creator = @Creator
		
END