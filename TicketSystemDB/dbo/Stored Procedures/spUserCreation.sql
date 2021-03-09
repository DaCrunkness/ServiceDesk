CREATE PROCEDURE [dbo].[spUserCreation]
	@FirstName nvarchar(50),
	@LastName nvarchar(50), 
	@PhoneNumber nvarchar(50), 
	@EmailAddress nvarchar(256),
	@UsersGroup nvarchar(256)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Users (FirstName, LastName, PhoneNumber, EmailAddress, UsersGroup)
                                         VALUES (@FirstName, @LastName, @PhoneNumber, @EmailAddress, @UsersGroup);
END