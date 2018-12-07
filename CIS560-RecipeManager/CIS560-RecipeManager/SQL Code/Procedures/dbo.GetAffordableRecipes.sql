CREATE PROCEDURE [dbo].[GetAffordableRecipes]
	@MaxMoneyToSpendInCents INT

AS
SELECT DISTINCT recipeCostCTE.RecipeID, recipeCostCTE.RecipeCostInCents
FROM 
(
	SELECT ingToBuyCTE.RecipeID, 
		(SUM(ingToBuyCTE.IngCostInCents) OVER (PARTITION BY ingToBuyCTE.RecipeID)) AS RecipeCostInCents
	FROM
	(
		SELECT rIng.PantryItemID, rIng.RecipeID, 
			SUM(pItem.UnitPriceInCents * (rIng.RecipeQuantity - pItem.QuantityInPantry)) AS IngCostInCents
		FROM	[dbo].RecipeIngredient rIng
			LEFT JOIN [dbo].PantryItem pItem ON rIng.PantryItemID = pItem.PantryItemID
			LEFT JOIN [dbo].Recipes r ON rIng.RecipeID = r.RecipeID
		WHERE (pItem.QuantityInPantry - rIng.RecipeQuantity) < 0
		GROUP BY rIng.PantryItemID, rIng.RecipeID
		UNION
		SELECT rIng.PantryItemID, rIng.RecipeID, 
			SUM(0) AS IngCostInCents
		FROM	[dbo].RecipeIngredient rIng
			LEFT JOIN [dbo].PantryItem pItem ON rIng.PantryItemID = pItem.PantryItemID
			LEFT JOIN [dbo].Recipes r ON rIng.RecipeID = r.RecipeID
		WHERE (pItem.QuantityInPantry - rIng.RecipeQuantity) >= 0
		GROUP BY rIng.PantryItemID, rIng.RecipeID
		) ingToBuyCTE

	) RecipeCostCTE
	WHERE recipeCostCTE.RecipeCostInCents <= @MaxMoneyToSpendInCents
	
--Returns rows with recipe information based on whether the recipe can be made with the current
--stock of Pantry Items and the given amount of money the user can utilize to make purchases
--of ingredients to create the recipe. 	
	