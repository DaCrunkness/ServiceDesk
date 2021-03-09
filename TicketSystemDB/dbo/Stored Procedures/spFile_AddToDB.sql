CREATE PROCEDURE [dbo].[spFile_AddToDB]
	@Name NVARCHAR(256),
	@Extension NVARCHAR(256), 
	@Path NVARCHAR(256), 
	@Type NVARCHAR(256)

AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO  dbo.FileInfo ([Name], [Extension], [Path], [Type])
                                         values (@Name, @Extension, @Path, @Type);
END