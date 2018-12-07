CREATE PROCEDURE [dbo].[GetAllRecipeIDs]

AS
SELECT [dbo].Recipes.RecipeID
FROM [dbo].Recipes

--Returns all RecipeIDs from the Recipes table, effectively returning all recipes in the database (as RecipeID is the primary key of the table)