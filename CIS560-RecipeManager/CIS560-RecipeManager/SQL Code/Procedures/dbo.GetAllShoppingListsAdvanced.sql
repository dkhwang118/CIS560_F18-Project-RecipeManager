CREATE PROCEDURE [dbo].[GetAllShoppingListsAdvanced]

AS
SELECT 
	SL.ShoppingListID,
	SL.ShoppingListName,
	SLI.PantryItemID,
	pItem.PantryItemName,
	pItem.ItemUnitMeasurement,
	SLI.QuantityToPurchase,
	pItem.UnitPriceInCents
FROM [dbo].ShoppingList SL
	INNER JOIN [dbo].ShoppingListItem SLI ON SL.ShoppingListID = SLI.ShoppingListID
	INNER JOIN [dbo].PantryItem pItem ON SLI.PantryItemID = pItem.PantryItemID 
GROUP BY SL.ShoppingListID, SL.ShoppingListName, SLI.PantryItemID,	pItem.PantryItemName, pItem.ItemUnitMeasurement, SLI.QuantityToPurchase, pItem.UnitPriceInCents
ORDER BY SL.ShoppingListID ASC, SLI.PantryItemID

--Returns a row for each ShoppingListItem in the ShoppingListItem table
--This procedure aggregates data from multiple tables for easy C# object creation for the GUI