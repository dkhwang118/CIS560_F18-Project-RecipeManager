CREATE TABLE [dbo].[ShoppingListItem] (
    [PantryItemID]       INT NOT NULL,
    [ShoppingListID]     INT NOT NULL,
    [QuantityToPurchase] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([PantryItemID] ASC, [ShoppingListID] ASC),
    CONSTRAINT [FK_ShoppingListItem_ShoppingList] FOREIGN KEY ([ShoppingListID]) REFERENCES [dbo].[ShoppingList] ([ShoppingListID]),
    CONSTRAINT [FK_ShoppingListItem_PantryItem] FOREIGN KEY ([PantryItemID]) REFERENCES [dbo].[PantryItem] ([PantryItemID])
);

