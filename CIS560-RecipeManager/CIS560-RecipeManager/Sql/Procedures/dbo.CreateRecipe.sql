CREATE PROCEDURE [dbo].CreateRecipe
	@RecipeID INT OUTPUT,
	@RecipeName NVARCHAR(32),
	@RecipeDescription NVARCHAR(MAX),
	@CategoryID INT,
	@RecipeRating INT

AS

INSERT [dbo].Recipes(RecipeName, RecipeDescription, CategoryID, RecipeRating)
VALUES(@RecipeName, @RecipeDescription, @CategoryID, @RecipeRating);

SET @RecipeID = SCOPE_IDENTITY();