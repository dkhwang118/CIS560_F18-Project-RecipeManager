CREATE PROCEDURE [dbo].CreateRecipeWithoutRating
	@RecipeID INT OUTPUT,
	@RecipeName NVARCHAR(32),
	@RecipeDescription NVARCHAR(MAX),
	@CategoryID INT

AS

INSERT [dbo].Recipes(RecipeName, RecipeDescription, CategoryID)
VALUES(@RecipeName, @RecipeDescription, @CategoryID)

SET @RecipeID = SCOPE_IDENTITY();

--CREATEs a new row in the Recipes table with the relevant Recipe data
--This procedure DOES NOT INCLUDE adding a RecipeRating
--OUTPUTs the associated RecipeID as defined by the value returned by SCOPE_IDENTITY()