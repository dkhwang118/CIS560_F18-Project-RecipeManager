CREATE PROCEDURE [dbo].CreateRecipeWithoutRating
	@RecipeID INT OUTPUT,
	@RecipeName NVARCHAR(32),
	@RecipeDescription NVARCHAR(MAX),
	@CategoryID INT

AS

INSERT [dbo].Recipes(RecipeName, RecipeDescription, CategoryID)
VALUES(@RecipeName, @RecipeDescription, @CategoryID)

SET @RecipeID = SCOPE_IDENTITY();