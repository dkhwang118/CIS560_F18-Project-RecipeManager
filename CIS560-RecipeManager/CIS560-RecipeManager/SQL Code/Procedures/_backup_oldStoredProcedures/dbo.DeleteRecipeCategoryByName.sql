CREATE PROCEDURE [dbo].[DeleteRecipeCategory]
	@CategoryName NVARCHAR(64)
AS

DELETE [dbo].[RecipeCategory]
WHERE CategoryName = @CategoryName;