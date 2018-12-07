CREATE PROCEDURE [dbo].[RateRecipe]
	@RecipeID INT,
	@RecipeRating INT

AS

UPDATE [dbo].Recipes
SET RecipeRating = @RecipeRating
WHERE RecipeID = @RecipeID

--UPDATEs a row in the Recipes table with the given Recipe Rating. Recipe updated is defined by the RecipeID given
--Effectively allows for users to update Recipe Ratings