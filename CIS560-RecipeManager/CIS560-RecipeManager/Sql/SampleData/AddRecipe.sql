INSERT INTO [dbo].[RecipeCategory] (CategoryID, CategoryName)
VALUES (1, N'strange food'),
       (2, N'Chicken stuff')
;

INSERT INTO [dbo].[Recipes] (RecipeName, RecipeDescription, CategoryID)
VALUES (N'Chicken and Rice', N'Cook some rice\n cook some chicken\n put the chicken on the rice.', 2),
       (N'Peppered Rice', N'Just put some pepper on rice.', 1)
;

DECLARE @PepperRiceID INT = (SELECT r.RecipeID FROM Recipes r where r.RecipeName = N'Peppered Rice'),
        @ChickenRiceID INT = (SELECT r.RecipeID FROM Recipes r where r.RecipeName = N'Chicken and Rice'),
        @PepperIngredientID INT = (SELECT p.PantryItemID FROM PantryItem p where p.PantryItemName = N'Rice'),
        @RiceIngredientID INT = (SELECT p.PantryItemID FROM PantryItem p where p.PantryItemName = N'Pepper'),
        @ChickenIngredientID INT = (SELECT p.PantryItemID FROM PantryItem p where p.PantryItemName = N'Chicken');


INSERT INTO [dbo].[RecipeIngredient] (RecipeID, PantryItemID, RecipeQuantity)
VALUES -- Peppered Rice.
       (@PepperRiceID, @PepperIngredientID, 1),
	   (@PepperRiceID, @RiceIngredientID, 1),
	   -- Chicken and Rice
	   (@ChickenRiceID, @RiceIngredientID, 1),
	   (@ChickenRiceID, @ChickenIngredientID, 2);
