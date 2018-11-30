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
--RETURN 1