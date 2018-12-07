CREATE PROCEDURE [dbo].[GetRecipesCookedLeastRecent]

AS

SELECT r.RecipeID,
	CONVERT(NVARCHAR(64), rcd.LastDateCooked) AS LastDateCooked,
    RANK() OVER(ORDER BY rcd.LastDateCooked ASC) AS Ranking
FROM [dbo].RecipesCookedDates rcd
	INNER JOIN [dbo].Recipes r ON r.RecipeID = rcd.RecipeId
ORDER BY rcd.LastDateCooked ASC

--returns all RecipeIDs which have been cooked at least once, in ascending order of their LastDateCooked column value
--Effectively returns all cooked recipes, ordered by the greatest amount of time since last cooked to least amount of time since last cooked