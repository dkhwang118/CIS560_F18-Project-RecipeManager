CREATE PROCEDURE [dbo].FindRecipeIngredientInfoByID
	@ItemID int
AS
	SELECT ri.RecipeID,
           ri.RecipeID,
           ri.RecipeQuantity
	FROM RecipeIngredient ri
	WHERE ri.RecipeID = @ItemID
--NOTE: This procedure was used initially, but is now not supported.