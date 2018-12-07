CREATE PROCEDURE [dbo].NumberMakeable
	@RecipeID INT
AS
SELECT MIN(PI.QuantityInPantry / RI.RecipeQuantity)
FROM [dbo].RecipeIngredient RI
    JOIN PantryItem PI ON RI.PantryItemID = PI.PantryItemID
WHERE RI.RecipeID = @RecipeID
GROUP BY RI.RecipeID;

--RETURNs the maximum amount of times a Recipe can be "cooked" given the Quantity of the Recipe's Ingredients currently in stock