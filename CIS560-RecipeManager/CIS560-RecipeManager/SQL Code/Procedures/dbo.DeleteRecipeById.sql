CREATE PROCEDURE [dbo].[DeleteRecipeById]
	@RecipeID int

AS

DELETE FROM [dbo].Recipes
WHERE RecipeID = @RecipeID

--DELETEs a row from the Recipes table, effectively deleting a recipe from the database
--NOTE: NOT IMPLEMENTED; KEEPING FOR FUTURE USE