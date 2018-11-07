CREATE PROCEDURE [dbo].[AddIngredient]
	@IngredientId INT OUTPUT,
	@Name NVARCHAR(64),
	@QuantityInPantry INT,
	@UnitMeasurement NVARCHAR(64)
AS

INSERT [dbo].Ingredient([Name], QuantityInPantry, UnitMeasurement)
VALUES(@Name, @QuantityInPantry, @UnitMeasurement);

SET @IngredientId = SCOPE_IDENTITY();
