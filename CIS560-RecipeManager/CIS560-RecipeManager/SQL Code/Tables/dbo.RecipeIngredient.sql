CREATE TABLE [dbo].[RecipeIngredient] (
    [PantryItemID]   INT NOT NULL,
    [RecipeID]       INT NOT NULL,
    [RecipeQuantity] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([PantryItemID] ASC, [RecipeID] ASC),
    CONSTRAINT [FK_RecipeIngredient_Recipes] FOREIGN KEY ([RecipeID]) REFERENCES [dbo].[Recipes] ([RecipeID]),
    CONSTRAINT [FK_RecipeIngredient_PantryItem] FOREIGN KEY ([PantryItemID]) REFERENCES [dbo].[PantryItem] ([PantryItemID])
);

