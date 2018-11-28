using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using CIS560_RecipeManager.RecipeManager;

namespace CIS560_RecipeManager.Repository
{
    public partial class Query : IQuery
    {
        public ICollection<ShoppingList> GetAllShoppingLists()
        {
            List<ShoppingList> returnList = new List<ShoppingList>();
            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                connection.Open();
                // Get all shoppingListID's and their names
                using (var transaction = new TransactionScope())
                {

                    using (var command = new SqlCommand("[dbo].GetAllShoppingListsAdvanced", connection)) // this procedure returns rows as follows: ShoppingListID, ShoppingListName, PantryItemID, PantryItemName, ItemUnitMeasurement, QuantityToPurchase
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        var result = command.ExecuteReader();

                        if (result.HasRows)
                        {
                            int lastShoppingListId;
                            int shoppingListID;
                            string shoppingListName;
                            int pantryItemID;
                            string pantryItemName;
                            string itemUnitMeasurement;
                            int quantityToPurchase;
                            ShoppingList tempSL;

                            // First time through; setup new shopping list and first item
                            result.Read();

                            shoppingListID = result.GetFieldValue<int>(0);
                            shoppingListName = result.GetFieldValue<string>(1);
                            pantryItemID = result.GetFieldValue<int>(2);
                            pantryItemName = result.GetFieldValue<string>(3);
                            itemUnitMeasurement = result.GetFieldValue<string>(4);
                            quantityToPurchase = result.GetFieldValue<int>(5);

                            tempSL = new ShoppingList(shoppingListID, shoppingListName); // create first ShoppingList object
                            tempSL.AddShoppingListItem(new Ingredient(pantryItemID, pantryItemName, itemUnitMeasurement), quantityToPurchase);

                            lastShoppingListId = shoppingListID;

                            // continue to read through the rows
                            while (result.Read())
                            {
                                shoppingListID = result.GetFieldValue<int>(0);
                                shoppingListName = result.GetFieldValue<string>(1);
                                pantryItemID = result.GetFieldValue<int>(2);
                                pantryItemName = result.GetFieldValue<string>(3);
                                itemUnitMeasurement = result.GetFieldValue<string>(4);
                                quantityToPurchase = result.GetFieldValue<int>(5);

                                if (lastShoppingListId == shoppingListID) // if the shoppingListItem is still on the same list
                                {
                                    // add the ingredient to the list
                                    tempSL.AddShoppingListItem(new Ingredient(pantryItemID, pantryItemName, itemUnitMeasurement), quantityToPurchase);
                                }
                                else
                                {
                                    // List number has changed; add ShoppingList to returnList and create new list
                                    returnList.Add(tempSL);
                                    tempSL = new ShoppingList(shoppingListID, shoppingListName);
                                    tempSL.AddShoppingListItem(new Ingredient(pantryItemID, pantryItemName, itemUnitMeasurement), quantityToPurchase);

                                }

                                // update lastShoppingListID
                                lastShoppingListId = shoppingListID;

                            }

                            // out of loop; close out last shopping list and return the List of ShoppingLists
                            returnList.Add(tempSL);

                        } // out of if statement; jump here if no rows present and return an empty list

                        return returnList;
                    }
                } // end current transaction
            }

        }
    }
}

