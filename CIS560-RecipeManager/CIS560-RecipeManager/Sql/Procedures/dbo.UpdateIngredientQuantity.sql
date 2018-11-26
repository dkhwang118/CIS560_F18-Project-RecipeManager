CREATE PROCEDURE [dbo].[UpdateIngredientQuantity]
	@PantryItemID int,
	@QuantityInPantry int
AS

UPDATE [dbo].PantryItem
SET QuantityInPantry = @QuantityInPantry
WHERE PantryItemID = @PantryItemID
