CREATE PROCEDURE [dbo].[DeleteRecipeIngredientsByRecipeId]
	@RecipeID INT

AS

DELETE FROM [dbo].RecipeIngredient
WHERE RecipeID = @RecipeID

--DELETEs rows in the RecipeIngredient table using the given RecipeID, effectively deleting the Recipe's ties to its ingredients
--NOTE: NOT IMPLEMENTED; SAVING FOR LATER USE