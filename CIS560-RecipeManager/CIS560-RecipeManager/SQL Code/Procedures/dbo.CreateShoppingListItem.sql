CREATE PROCEDURE [dbo].[CreateShoppingListItem]
	@PantryItemID INT,
	@ShoppingListID INT,
	@QuantityToPurchase INT

AS

INSERT [dbo].ShoppingListItem(PantryItemID, ShoppingListID, QuantityToPurchase)
VALUES(@PantryItemID, @ShoppingListID, @QuantityToPurchase)

--INSERTs a row into the ShoppingListItem table that effectively links the ShoppingList to the Ingredient and its Quantity in the Shopping List
