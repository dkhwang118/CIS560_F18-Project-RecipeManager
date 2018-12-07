CREATE PROCEDURE [dbo].[DeleteRecipeCategory]
	@CategoryName NVARCHAR(64)
AS

DELETE [dbo].[RecipeCategory]
WHERE CategoryName = @CategoryName;

--DELETEs a row in the RecipeCategory table using the given Recipe CategoryName, deleting the Recipe Category from the database
--NOTE: NOT IMPLEMENTED; SAVING FOR LATER USE