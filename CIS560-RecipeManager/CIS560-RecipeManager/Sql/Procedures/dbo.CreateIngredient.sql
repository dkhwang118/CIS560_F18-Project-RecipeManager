CREATE PROCEDURE [dbo].[CreateIngredient]
	@PantryItemID INT OUTPUT,
	@PantryItemName NVARCHAR(32),
	@QuantityInPantry INT,
	@ItemUnitMeasurement NVARCHAR(32)

AS

INSERT [dbo].PantryItem(PantryItemName, QuantityInPantry, ItemUnitMeasurement)
VALUES(@PantryItemName, @QuantityInPantry, @ItemUnitMeasurement)

SET @PantryItemID = SCOPE_IDENTITY();
