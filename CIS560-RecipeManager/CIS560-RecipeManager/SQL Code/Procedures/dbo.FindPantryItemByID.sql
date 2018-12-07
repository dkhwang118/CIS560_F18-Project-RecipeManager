CREATE PROCEDURE [dbo].FindPantryItemByID
	@ItemID int
AS
	SELECT p.PantryItemID, 
           p.PantryItemName,
           p.QuantityInPantry,
           p.ItemUnitMeasurement,
		   p.UnitPriceInCents
	FROM PantryItem p
	WHERE p.PantryItemID = @ItemID 

--Returns a row in the PantryItem table by the given ItemID, effectively returning a Pantry Item that is being searched for