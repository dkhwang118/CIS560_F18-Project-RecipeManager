CREATE TABLE [dbo].[ShoppingListItem] (
    [IngredientId]       INT NOT NULL,
    [ShoppingListId]     INT NOT NULL,
    [QuantityToPurchase] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([IngredientId] ASC, [ShoppingListId] ASC),
    CONSTRAINT [FK_ShoppingListItem_ShoppingList] FOREIGN KEY ([ShoppingListId]) REFERENCES [dbo].[ShoppingList] ([ShoppingListId]),
    CONSTRAINT [FK_ShoppingListItem_Ingredient] FOREIGN KEY ([IngredientId]) REFERENCES [dbo].[Ingredient] ([IngredientId])
);

