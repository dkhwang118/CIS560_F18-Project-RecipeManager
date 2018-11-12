CREATE PROCEDURE [dbo].FindRecipeItemByID
	@ItemID int
AS
	SELECT r.RecipeID,
           r.RecipeName,
           r.RecipeDescription,
           r.CategoryID
	FROM Recipes r
	WHERE r.RecipeID = @ItemID