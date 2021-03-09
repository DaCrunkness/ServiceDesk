CREATE PROCEDURE [dbo].[spError_LookUp]
	@CODE INT
AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Code], [Type], [Phrase], [Message]
		From [dbo].[Errors]
		WHERE Code = @Code
END
