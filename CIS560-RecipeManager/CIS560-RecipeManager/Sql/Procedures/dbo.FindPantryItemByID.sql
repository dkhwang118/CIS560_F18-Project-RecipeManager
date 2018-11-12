CREATE PROCEDURE [dbo].FindPantryItemByID
	@ItemID int
AS
	SELECT p.PantryItemID, 
           p.PantryItemName,
           p.QuantityInPantry,
           p.ItemUnitMeasurement
	FROM PantryItem p
	WHERE p.PantryItemID = @ItemID 
RETURN 0
