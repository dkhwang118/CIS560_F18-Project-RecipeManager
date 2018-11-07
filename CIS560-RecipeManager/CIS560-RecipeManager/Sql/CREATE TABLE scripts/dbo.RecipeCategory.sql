CREATE TABLE [dbo].[RecipeCategory] (
    [CategoryId]   INT IDENTITY(1,1)          NOT NULL,
    [CategoryName] NVARCHAR (64) NOT NULL,
    PRIMARY KEY CLUSTERED ([CategoryId] ASC)
);

