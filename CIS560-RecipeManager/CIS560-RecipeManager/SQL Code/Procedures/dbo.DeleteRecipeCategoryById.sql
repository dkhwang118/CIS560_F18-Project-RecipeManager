CREATE PROCEDURE [dbo].[DeleteRecipeCategoryById]
	@CategoryID INT
AS

DELETE [dbo].[RecipeCategory]
WHERE CategoryID = @CategoryID;

--DELETEs a row in the RecipeCategory table using the given CategoryID, deleting the RecipeCategory from the database
--NOTE: NOT IMPLEMENTED; SAVING FOR LATER USE