CREATE PROCEDURE [dbo].[UpdateRecipesCookedDates]
	@RecipeID INT

AS


MERGE INTO [dbo].RecipesCookedDates AS TARGET
	USING
	(SELECT
		@RecipeID AS RecipeId,
		1 AS TimesCooked,
		SYSDATETIMEOFFSET() AS LastDateCooked
		)
		AS SOURCE (RecipeId, TimesCooked, LastDateCooked)
	ON (TARGET.RecipeId = SOURCE.RecipeId)

WHEN MATCHED THEN 
	UPDATE
		SET TARGET.TimesCooked = TARGET.TimesCooked + 1,
			TARGET.LastDateCooked = SYSDATETIMEOFFSET()
WHEN NOT MATCHED THEN 
	INSERT (RecipeId, TimesCooked, LastDateCooked)
		VALUES (@RecipeID, 1, SYSDATETIMEOFFSET());
		
--CREATE OR UPDATE a row in RecipesCookedDates table when the user "cooks" a recipe