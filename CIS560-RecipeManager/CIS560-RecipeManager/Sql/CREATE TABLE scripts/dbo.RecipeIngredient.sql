CREATE TABLE [dbo].[RecipeIngredient] (
    [IngredientId]   INT NOT NULL,
    [RecipeId]       INT NOT NULL,
    [RecipeQuantity] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([IngredientId] ASC, [RecipeId] ASC),
    CONSTRAINT [FK_RecipeIngredient_Ingredient] FOREIGN KEY ([IngredientId]) REFERENCES [dbo].[Ingredient] ([IngredientId]),
    CONSTRAINT [FK_RecipeIngredient_Recipes] FOREIGN KEY ([RecipeId]) REFERENCES [dbo].[Recipes] ([RecipeID])
);

