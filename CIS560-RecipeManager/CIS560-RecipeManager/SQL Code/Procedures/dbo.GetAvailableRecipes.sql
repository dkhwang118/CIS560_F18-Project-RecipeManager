CREATE PROCEDURE [dbo].[GetAvailableRecipes]
AS
	SELECT R.RecipeID
	FROM[dbo].[Recipes] R
	-- I would prefer for a way to check forall x.P(x) rather than not exists x.not p(x).
	WHERE NOT EXISTS
	   (
		  SELECT 1
		  FROM[dbo].RecipeIngredient RI
			JOIN[dbo].PantryItem[PI] ON RI.PantryItemID = [PI].PantryItemID
		  WHERE R.RecipeID = RI.RecipeID
			AND [PI].QuantityInPantry < RI.RecipeQuantity
		);
RETURN 0
