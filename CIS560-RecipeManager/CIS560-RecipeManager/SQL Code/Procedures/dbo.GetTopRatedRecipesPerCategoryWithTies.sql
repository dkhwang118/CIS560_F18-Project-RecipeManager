CREATE PROCEDURE [dbo].[GetTopRatedRecipesPerCategoryWithTies]
	@RecipesPerCategory INT

AS

SELECT tempCTE.CategoryID, tempCTE.CategoryName, tempCTE.RecipeID, tempCTE.RecipeRating, tempCTE.RankInCategory
FROM 
(
	SELECT ratedRecipes.CategoryID, rc.CategoryName, ratedRecipes.RecipeID, ratedRecipes.RecipeRating,
	RANK() OVER(PARTITION BY ratedRecipes.CategoryID ORDER BY ratedRecipes.RecipeRating DESC) RankInCategory
	FROM 
	(
		SELECT *
		FROM [dbo].Recipes r
		WHERE r.RecipeRating IS NOT NULL
	) AS ratedRecipes
		INNER JOIN [dbo].RecipeCategory rc ON ratedRecipes.CategoryID = rc.CategoryID
	
) tempCTE WHERE tempCTE.RankInCategory <= @RecipesPerCategory