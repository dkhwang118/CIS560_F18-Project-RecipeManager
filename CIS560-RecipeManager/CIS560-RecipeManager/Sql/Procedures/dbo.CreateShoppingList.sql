CREATE PROCEDURE [dbo].[CreateShoppingList]
	@ShoppingListID INT OUTPUT,
	@ShoppingListName NVARCHAR(64),
	@CreatedOn DATETIME,
	@UpdatedOn DATETIME

AS

INSERT [dbo].ShoppingList(ShoppingListName, CreatedOn, UpdatedOn)
VALUES(@ShoppingListName, SYSDATETIMEOFFSET(), SYSDATETIMEOFFSET())

SET @ShoppingListID = SCOPE_IDENTITY();
