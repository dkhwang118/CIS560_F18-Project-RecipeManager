CREATE TABLE [dbo].[ShoppingList] (
    [ShoppingListId]   INT IDENTITY(1,1)                NOT NULL,
    [ShoppingListName] NVARCHAR (64)      NOT NULL,
    [CreatedOn]        DATETIMEOFFSET (7) DEFAULT (sysdatetimeoffset()) NOT NULL,
    [UpdatedOn]        DATETIMEOFFSET (7) DEFAULT (sysdatetimeoffset()) NOT NULL,
    PRIMARY KEY CLUSTERED ([ShoppingListId] ASC),
    UNIQUE NONCLUSTERED ([ShoppingListName] ASC)
);

