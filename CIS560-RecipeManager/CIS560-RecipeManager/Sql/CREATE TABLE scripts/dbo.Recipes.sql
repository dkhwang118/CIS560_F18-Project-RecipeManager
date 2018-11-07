CREATE TABLE [dbo].[Recipes] (
    [RecipeId]          INT            IDENTITY (1, 1) NOT NULL,
    [RecipeName]        NVARCHAR (64)  NOT NULL,
    [RecipeDescription] NVARCHAR (MAX) NOT NULL,
    [CategoryId]        INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([RecipeId] ASC),
    CONSTRAINT [FK_Recipes_RecipeCategory] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[RecipeCategory] ([CategoryId])
);

