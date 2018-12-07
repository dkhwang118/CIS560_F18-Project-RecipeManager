CREATE PROCEDURE [dbo].[GetRecipeCategory]
	@recipeID int 
AS

SELECT RC.CategoryID, RC.CategoryName
FROM dbo.Recipes R
	INNER JOIN dbo.RecipeCategory RC ON RC.CategoryID = R.CategoryID
WHERE R.RecipeID = @recipeID

--Returns a Recipe Category given the RecipeID passed in. 
--Effectively gets the Recipe Category associated with the Recipe 