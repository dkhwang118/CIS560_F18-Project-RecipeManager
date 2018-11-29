CREATE PROCEDURE [dbo].[GetTopRatedRecipesPerCategoryWithTies]
	@RecipesPerCategory INT

AS

SELECT tempCTE.CategoryID, tempCTE.CategoryName, tempCTE.RecipeID, tempCTE.RecipeRating
FROM 
(
	SELECT r.CategoryID, rc.CategoryName, r.RecipeID, r.RecipeRating,
	RANK() OVER(PARTITION BY r.CategoryID ORDER BY r.RecipeRating DESC) RankInCategory
	
	FROM [dbo].Recipes r
		INNER JOIN [dbo].RecipeCategory rc ON r.CategoryID = rc.CategoryID
) tempCTE WHERE RankInCategory <= @RecipesPerCategory
