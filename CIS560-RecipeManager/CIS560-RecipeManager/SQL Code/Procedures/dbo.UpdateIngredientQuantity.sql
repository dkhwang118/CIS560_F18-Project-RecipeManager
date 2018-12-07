CREATE PROCEDURE [dbo].[UpdateIngredientQuantity]
	@PantryItemID int,
	@QuantityInPantry int
AS

UPDATE [dbo].PantryItem
SET QuantityInPantry = @QuantityInPantry
WHERE PantryItemID = @PantryItemID

--UPDATEs a PantryItem table row with the given @QuantityInPantry value. Row updated is based on the PantryItemID given
--Effectively allows the application to change pantry quantities in a variety of situations