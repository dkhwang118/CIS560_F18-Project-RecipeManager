CREATE PROCEDURE [dbo].[CreateShoppingList]
	@ShoppingListID INT OUTPUT,
	@ShoppingListName NVARCHAR(64)

AS

INSERT [dbo].ShoppingList(ShoppingListName, CreatedOn, UpdatedOn)
VALUES(@ShoppingListName, SYSDATETIMEOFFSET(), SYSDATETIMEOFFSET())

SET @ShoppingListID = SCOPE_IDENTITY();

--CREATEs a row in the ShoppingList table with the necessary data and OUTPUTs the associated ShoppingListID 