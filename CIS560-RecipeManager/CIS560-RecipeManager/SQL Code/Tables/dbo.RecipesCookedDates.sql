CREATE TABLE [dbo].[RecipesCookedDates] (
    [RecipeId]       INT      NOT NULL,
    [TimesCooked]    INT      NOT NULL,
    [LastDateCooked] DATETIME NULL,
    PRIMARY KEY CLUSTERED ([RecipeId] ASC),
    CONSTRAINT [FK_RecipesCookedDates_Recipes] FOREIGN KEY ([RecipeId]) REFERENCES [dbo].[Recipes] ([RecipeID])
);

