CREATE PROCEDURE [dbo].[RateRecipe]
	@RecipeID INT,
	@RecipeRating INT

AS

UPDATE [dbo].Recipes
SET RecipeRating = @RecipeRating
WHERE RecipeID = @RecipeID