CREATE PROCEDURE [dbo].[CreateRecipeCategory]
	@CategoryID INT OUTPUT,
	@CategoryName NVARCHAR(64)
AS

INSERT [dbo].RecipeCategory(CategoryName)
VALUES(@CategoryName);

SET @CategoryID = SCOPE_IDENTITY();

--CREATEs a new row in the RecipeCategory table with the relevant RecipeCategory data
--OUTPUTs the associated CategoryID as defined by the SCOPE_IDENTITY() value of the table.