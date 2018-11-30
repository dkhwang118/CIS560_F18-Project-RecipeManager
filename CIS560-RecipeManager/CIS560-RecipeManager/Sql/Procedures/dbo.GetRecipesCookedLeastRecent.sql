CREATE PROCEDURE [dbo].[GetRecipesCookedLeastRecent]

AS

SELECT r.RecipeID,
	CONVERT(NVARCHAR(64), rcd.LastDateCooked) AS LastDateCooked,
    RANK() OVER(ORDER BY rcd.LastDateCooked ASC) AS Ranking
FROM [dbo].RecipesCookedDates rcd
	INNER JOIN [dbo].Recipes r ON r.RecipeID = rcd.RecipeId
ORDER BY rcd.LastDateCooked ASC