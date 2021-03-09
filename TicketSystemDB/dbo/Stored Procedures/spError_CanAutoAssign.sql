CREATE PROCEDURE [dbo].[spError_CanAutoAssign]
	@CODE INT
AS
BEGIN
	SET NOCOUNT ON;

	SELECT WillAutoAssign
		From [dbo].[Errors]
		WHERE Code = @Code
END