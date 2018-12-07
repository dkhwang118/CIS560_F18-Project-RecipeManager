CREATE TABLE [dbo].[RecipeCategory] (
    [CategoryID]   INT           IDENTITY (1, 1) NOT NULL,
    [CategoryName] NVARCHAR (64) NOT NULL,
    PRIMARY KEY CLUSTERED ([CategoryID] ASC)
);

