CREATE PROCEDURE [dbo].[spError_CanAutoAssign]
	@Code INT
AS
BEGIN
	SET NOCOUNT ON;

	SELECT WillAutoAssign
		From [dbo].[Errors]
		WHERE Code = @Code
END