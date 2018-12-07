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
	
--Returns a Recipe and its associated row data from the Recipes table given an ItemID parameter