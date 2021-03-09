CREATE PROCEDURE [dbo].[spUserLookup]
	@EmailAddress nvarchar(256)
AS
BEGIN
	SET NOCOUNT ON;

	SELECT FirstName, LastName, PhoneNumber, EmailAddress, UsersGroup
		From [dbo].[Users]
		WHERE EmailAddress = @EmailAddress
END
