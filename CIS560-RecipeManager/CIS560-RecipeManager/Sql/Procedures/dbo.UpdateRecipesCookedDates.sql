CREATE PROCEDURE [dbo].[UpdateRecipesCookedDates]
	@RecipeID INT

AS

IF EXISTS (SELECT 1 FROM [dbo].RecipesCookedDates WHERE RecipeId = @RecipeID)
BEGIN
	UPDATE [dbo].RecipesCookedDates
		SET TimesCooked += 1,
			LastDateCooked = SYSDATETIMEOFFSET()
		WHERE RecipeId = @RecipeID
END
ELSE
BEGIN
	INSERT [dbo].RecipesCookedDates(RecipeId, TimesCooked, LastDateCooked)
	VALUES(@RecipeID, 1, SYSDATETIMEOFFSET())
END
		