CREATE PROCEDURE [dbo].[GetAvgRatingPerCategory]

AS

SELECT DISTINCT ratedRecipes.CategoryID, rc.CategoryName,
	AVG(CAST(ratedRecipes.RecipeRating AS decimal(6,4))) OVER(PARTITION BY ratedRecipes.CategoryID) AS AvgCatRating

FROM 
(
	SELECT *
	FROM [dbo].Recipes r
	WHERE r.RecipeRating IS NOT NULL
	) ratedRecipes
	INNER JOIN [dbo].RecipeCategory rc ON ratedRecipes.CategoryID = rc.CategoryID
	
--RETURNs rows for each Recipe Category in the database along with the aggregated Recipe Ratings average for all recipes within each Recipe Category