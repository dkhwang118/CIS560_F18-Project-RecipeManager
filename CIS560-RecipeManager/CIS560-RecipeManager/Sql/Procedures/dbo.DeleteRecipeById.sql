CREATE PROCEDURE [dbo].[DeleteRecipeById]
	@RecipeID int

AS

DELETE FROM [dbo].Recipes
WHERE RecipeID = @RecipeID
