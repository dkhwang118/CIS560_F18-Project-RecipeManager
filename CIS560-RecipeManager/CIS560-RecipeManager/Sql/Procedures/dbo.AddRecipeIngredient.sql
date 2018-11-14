CREATE PROCEDURE [dbo].[AddRecipeIngredient]
	@PantryItemID INT,
	@RecipeID INT,
	@RecipeQuantity INT

AS

INSERT [dbo].RecipeIngredient(PantryItemID, RecipeID, RecipeQuantity)
VALUES(@PantryItemID, @RecipeID, @RecipeQuantity);
