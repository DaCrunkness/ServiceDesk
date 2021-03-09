CREATE PROCEDURE [dbo].[spUser_GetUserGroup]
	@EmailAddress NVARCHAR(256)

AS
BEGIN
	SET NOCOUNT ON;

	SELECT UsersGroup 
		FROM [dbo].[Users]
		WHERE EmailAddress = @EmailAddress
		
END
