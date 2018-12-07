CREATE TABLE [dbo].[Recipes] (
    [RecipeID]          INT            IDENTITY (1, 1) NOT NULL,
    [RecipeName]        NVARCHAR (64)  NOT NULL,
    [RecipeDescription] NVARCHAR (MAX) NOT NULL,
    [CategoryID]        INT            NOT NULL,
    [RecipeRating]      INT            NULL,
    PRIMARY KEY CLUSTERED ([RecipeID] ASC),
    CONSTRAINT [FK_Recipes_RecipeCategory] FOREIGN KEY ([CategoryID]) REFERENCES [dbo].[RecipeCategory] ([CategoryID])
);

