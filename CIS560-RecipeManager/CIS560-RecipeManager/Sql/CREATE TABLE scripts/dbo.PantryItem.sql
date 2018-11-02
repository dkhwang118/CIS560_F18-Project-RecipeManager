CREATE TABLE [dbo].[PantryItem]
(
	[PantryItemID] INT NOT NULL PRIMARY KEY, 
    [PantryItemName] NVARCHAR(32) NOT NULL, 
    [QuantityInPantry] INT NOT NULL, 
    [ItemUnitMeasurement] NVARCHAR(32) NOT NULL
)
