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

--CREATEs a new row in the Recipes table with the relevant Recipe data
--NOTE: This procedure DOES INCLUDE adding a RecipeRating into the DB at the same time the recipe is added.
--OUTPUTs the associated RecipeID as defined by the return value from SCOPE_IDENTITY()