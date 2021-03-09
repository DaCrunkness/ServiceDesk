CREATE PROCEDURE [dbo].[spUserLoad]

AS
BEGIN
	SET NOCOUNT ON;
	
	 SELECT FirstName, LastName, PhoneNumber, EmailAddress, UsersGroup
		From dbo.Users;

END