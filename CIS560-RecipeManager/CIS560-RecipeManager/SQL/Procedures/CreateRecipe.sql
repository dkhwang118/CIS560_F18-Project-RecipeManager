CREATE OR ALTER PROCEDURE RecipeDatabaseDefaultDataSet.CreateRecipe
	@RecipeID INT OUTPUT,
	@RecipeName NVARCHAR(32)
AS

INSERT RecipeDatabaseDefaultDataSet.Recipes_DEMO(RecipeName)
VALUES(@RecipeName);

SET @RecipeID = SCOPE_IDENTITY();
GO