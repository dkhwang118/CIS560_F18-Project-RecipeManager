CREATE PROCEDURE [dbo].[GetAllRecipeCategories]

AS
SELECT *
FROM [dbo].RecipeCategory

--Returns all table data from the RecipeCategory table, effectively returning all Recipe Categories in the database