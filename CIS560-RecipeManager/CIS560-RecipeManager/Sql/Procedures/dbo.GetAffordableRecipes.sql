CREATE PROCEDURE [dbo].[GetAffordableRecipes]
	@MaxMoneyToSpendInCents INT

AS
SELECT DISTINCT tempCTE.RecipeID, tempCTE.RecipeCostInCents
FROM 
( 
	SELECT r.RecipeID, 
		(SUM(pItem.UnitPriceInCents * (rIng.RecipeQuantity - pItem.QuantityInPantry)) OVER(PARTITION BY r.RecipeID)) RecipeCostInCents
	FROM	[dbo].Recipes r
	INNER JOIN [dbo].RecipeIngredient rIng ON r.RecipeID = rIng.RecipeID
	INNER JOIN [dbo].PantryItem pItem ON rIng.PantryItemID = pItem.PantryItemID
	) tempCTE
WHERE RecipeCostInCents <= @MaxMoneyToSpendInCents 
