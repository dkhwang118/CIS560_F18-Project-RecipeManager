CREATE PROCEDURE [dbo].[DeleteRecipeIngredientsByRecipeId]
	@RecipeID INT

AS

DELETE FROM [dbo].RecipeIngredient
WHERE RecipeID = @RecipeID
