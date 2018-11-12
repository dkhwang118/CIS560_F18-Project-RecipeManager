CREATE PROCEDURE [dbo].FindRecipeIngredientInfoByID
	@ItemID int
AS
	SELECT ri.RecipeID,
           ri.RecipeID,
           ri.RecipeQuantity
	FROM RecipeIngredient ri
	WHERE ri.RecipeID = @ItemID

-- DROP PROCEDURE IF EXISTS [dbo].FindRecipeIngredientInfoByID;
	