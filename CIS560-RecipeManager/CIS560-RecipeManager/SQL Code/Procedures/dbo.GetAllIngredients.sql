CREATE PROCEDURE [dbo].[GetAllIngredients]

AS
	SELECT *
	FROM dbo.PantryItem
	
--Returns the entire PantryItem table and its row contents, effectively returning all Pantry Items in the database