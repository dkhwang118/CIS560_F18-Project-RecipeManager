CREATE PROCEDURE [dbo].[AddRecipeCategory]
	@CategoryID INT OUTPUT,
	@CategoryName NVARCHAR(64)
AS

INSERT [dbo].RecipeCategory(CategoryName)
VALUES(@CategoryName);

SET @CategoryID = SCOPE_IDENTITY();
