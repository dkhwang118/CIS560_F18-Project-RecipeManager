CREATE PROCEDURE [dbo].[AddRecipeIngredient]
	@PantryItemID int,
	@RecipeID int,
	@RecipeQuantity int
AS

INSERT [dbo].RecipeIngredient(PantryItemID, RecipeID, RecipeQuantity)
VALUES(@PantryItemID, @RecipeID, @RecipeQuantity)
