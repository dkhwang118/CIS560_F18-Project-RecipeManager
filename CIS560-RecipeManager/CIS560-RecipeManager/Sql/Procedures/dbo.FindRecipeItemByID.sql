CREATE PROCEDURE [dbo].FindRecipeItemByID
	@ItemID int
AS
	SELECT r.RecipeID,
           r.RecipeName,
           r.RecipeDescription,
           r.CategoryID,
		   r.RecipeRating
	FROM Recipes r
	WHERE r.RecipeID = @ItemID