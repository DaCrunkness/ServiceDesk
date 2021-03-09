CREATE PROCEDURE [dbo].[spError_InsertNew]
	@Code INT,
	@Type nvarchar(256), 
	@Phrase nvarchar(256), 
	@Message nvarchar(256),
	@WillAutoAssign nvarchar(256)
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO  dbo.Errors (Code, [Type], [Phrase], [Message], [WillAutoAssign])
                                         VALUES (@Code, @Type, @Phrase, @Message, @WillAutoAssign);
END