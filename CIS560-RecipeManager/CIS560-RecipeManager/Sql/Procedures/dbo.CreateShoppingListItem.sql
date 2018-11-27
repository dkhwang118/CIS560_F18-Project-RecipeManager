CREATE PROCEDURE [dbo].[CreateShoppingListItem]
	@PantryItemID INT,
	@ShoppingListID INT,
	@QuantityToPurchase INT

AS

INSERT [dbo].ShoppingListItem(PantryItemID, ShoppingListID, QuantityToPurchase)
VALUES(@PantryItemID, @ShoppingListID, @QuantityToPurchase) 

