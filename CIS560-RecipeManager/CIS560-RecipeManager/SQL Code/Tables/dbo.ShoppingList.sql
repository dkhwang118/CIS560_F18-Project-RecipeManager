CREATE TABLE [dbo].[ShoppingList] (
    [ShoppingListID]   INT                IDENTITY (1, 1) NOT NULL,
    [ShoppingListName] NVARCHAR (64)      NOT NULL,
    [CreatedOn]        DATETIMEOFFSET (7) DEFAULT (sysdatetimeoffset()) NOT NULL,
    [UpdatedOn]        DATETIMEOFFSET (7) DEFAULT (sysdatetimeoffset()) NOT NULL,
    PRIMARY KEY CLUSTERED ([ShoppingListID] ASC),
    UNIQUE NONCLUSTERED ([ShoppingListName] ASC)
);

