CREATE PROCEDURE [dbo].[spTickets_LoadAll]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT TicketNumber, Creator, Summary, Detail, CreateDate
		From [dbo].[Tickets]
		
END