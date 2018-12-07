CREATE PROCEDURE [dbo].[CreateIngredient]
	@PantryItemID INT OUTPUT,
	@PantryItemName NVARCHAR(32),
	@QuantityInPantry INT,
	@ItemUnitMeasurement NVARCHAR(32),
	@UnitPriceInCents INT

AS

INSERT [dbo].PantryItem(PantryItemName, QuantityInPantry, ItemUnitMeasurement, UnitPriceInCents)
VALUES(@PantryItemName, @QuantityInPantry, @ItemUnitMeasurement, @UnitPriceInCents)

SET @PantryItemID = SCOPE_IDENTITY();

--Creates a row in the PantryItem table with a Pantry Item's relevant data
--OUTPUTs the PantryItemID associated with the inserted row 