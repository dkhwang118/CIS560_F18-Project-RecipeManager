CREATE PROCEDURE [dbo].[CreateOrUpdateShoppingListItem]
	@PantryItemID INT,
	@ShoppingListID INT,
	@QuantityToPurchase INT

AS

MERGE INTO [dbo].ShoppingListItem AS TARGET
	USING (SELECT
		@PantryItemID AS PantryItemID,
		@ShoppingListID AS ShoppingListID,
		@QuantityToPurchase AS QuantityToPurchase)
		AS SOURCE(PantryItemID, ShoppingListID, QuantityToPurchase)
	ON (TARGET.PantryItemID = SOURCE.PantryItemID AND
			TARGET.ShoppingListID = SOURCE.ShoppingListID)
WHEN MATCHED
	THEN UPDATE
		SET TARGET.QuantityToPurchase = TARGET.QuantityToPurchase + @QuantityToPurchase
WHEN NOT MATCHED
	THEN INSERT
		VALUES(@PantryItemID, @ShoppingListID, @QuantityToPurchase);
		
--CREATEs or UPDATEs the ShoppingListItem table with the relevant new data given by the user