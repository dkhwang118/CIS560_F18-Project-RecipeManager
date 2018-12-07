CREATE PROCEDURE [dbo].[UpdateRecipeInRecipeTable]
	@RecipeID INT,
	@RecipeName NVARCHAR(64),
	@RecipeDescription NVARCHAR(MAX),
	@CategoryID INT

AS

UPDATE [dbo].Recipes 
SET 
	RecipeName = @RecipeName,
	RecipeDescription = @RecipeDescription,
	CategoryID = @CategoryID
WHERE RecipeID = @RecipeID