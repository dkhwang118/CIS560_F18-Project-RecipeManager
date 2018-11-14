CREATE PROCEDURE [dbo].[DeleteRecipeCategoryById]
	@CategoryID INT
AS

DELETE [dbo].[RecipeCategory]
WHERE CategoryID = @CategoryID;