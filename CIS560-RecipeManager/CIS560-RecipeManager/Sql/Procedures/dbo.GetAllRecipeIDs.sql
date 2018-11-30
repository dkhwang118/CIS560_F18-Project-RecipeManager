CREATE PROCEDURE [dbo].[GetAllRecipeIDs]

AS
SELECT [dbo].Recipes.RecipeID
FROM [dbo].Recipes