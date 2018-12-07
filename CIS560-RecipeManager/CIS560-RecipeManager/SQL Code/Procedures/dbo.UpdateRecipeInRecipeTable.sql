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

--UPDATEs a row in the Recipes table with the given parameters that are passed
--Effectively allows the application to update the Recipes table in a variety of user-interaction scenarios