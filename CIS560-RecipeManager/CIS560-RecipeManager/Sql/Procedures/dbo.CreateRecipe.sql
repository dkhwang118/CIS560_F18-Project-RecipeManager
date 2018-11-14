CREATE PROCEDURE [dbo].CreateRecipe
	@RecipeID INT OUTPUT,
	@RecipeName NVARCHAR(64),
	@RecipeDescription NVARCHAR(MAX),
	@CategoryID INT
AS

INSERT [dbo].Recipes(RecipeName, RecipeDescription, CategoryID)
VALUES(@RecipeName, @RecipeDescription, @CategoryID);

SET @RecipeID = SCOPE_IDENTITY();