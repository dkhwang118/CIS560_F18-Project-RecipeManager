CREATE TABLE [dbo].[Ingredient] (
    [IngredientId]     INT           IDENTITY(1,1) NOT NULL,
    [Name]             NVARCHAR (64) NOT NULL,
    [QuantityInPantry] INT           DEFAULT ((0)) NOT NULL,
    [UnitMeasurement]  NVARCHAR (64) NOT NULL,
    PRIMARY KEY CLUSTERED ([IngredientId] ASC),
    UNIQUE NONCLUSTERED ([Name] ASC)
);

