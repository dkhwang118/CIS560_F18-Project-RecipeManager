CREATE TABLE [dbo].[PantryItem] (
    [PantryItemID]        INT           IDENTITY(1,1) NOT NULL,
    [PantryItemName]      NVARCHAR (32) NOT NULL,
    [QuantityInPantry]    INT           NOT NULL,
    [ItemUnitMeasurement] NVARCHAR (32) NOT NULL,
    [UnitPrice]           INT           NULL,
    PRIMARY KEY CLUSTERED ([PantryItemID] ASC)
);

