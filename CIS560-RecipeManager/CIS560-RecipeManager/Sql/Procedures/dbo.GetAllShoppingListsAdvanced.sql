CREATE PROCEDURE [dbo].[GetAllShoppingListsAdvanced]

AS
SELECT 
	SL.ShoppingListID,
	SL.ShoppingListName,
	SLI.PantryItemID,
	pItem.PantryItemName,
	pItem.ItemUnitMeasurement,
	SLI.QuantityToPurchase
FROM [dbo].ShoppingList SL
	INNER JOIN [dbo].ShoppingListItem SLI ON SL.ShoppingListID = SLI.ShoppingListID
	INNER JOIN [dbo].PantryItem pItem ON SLI.PantryItemID = pItem.PantryItemID 
GROUP BY SL.ShoppingListID, SL.ShoppingListName, SLI.PantryItemID,	pItem.PantryItemName, pItem.ItemUnitMeasurement, SLI.QuantityToPurchase
ORDER BY SL.ShoppingListID ASC, SLI.PantryItemID
