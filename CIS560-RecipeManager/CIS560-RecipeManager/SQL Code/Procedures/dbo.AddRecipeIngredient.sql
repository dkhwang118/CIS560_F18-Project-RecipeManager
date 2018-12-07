CREATE PROCEDURE [dbo].[AddRecipeIngredient]
	@PantryItemID int,
	@RecipeID int,
	@RecipeQuantity int
AS

INSERT [dbo].RecipeIngredient(PantryItemID, RecipeID, RecipeQuantity)
VALUES(@PantryItemID, @RecipeID, @RecipeQuantity)

--Adds a row to the RecipeIngredient table, linking a Recipe to a Pantry Item and the Quantity of the item required 