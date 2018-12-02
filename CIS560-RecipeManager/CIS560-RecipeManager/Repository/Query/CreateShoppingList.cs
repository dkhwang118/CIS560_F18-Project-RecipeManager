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
        public ShoppingList CreateShoppingList(string shoppingListName, ICollection<Recipe> recipes)
        {
            ShoppingList slTemp;
            int shoppingListId;           
            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                connection.Open();
                // First: Create Shopping List to get ShoppingListId
                using (var transaction = new TransactionScope())
                {
                    using (var command = new SqlCommand("[dbo].CreateShoppingList", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("ShoppingListName", shoppingListName);
                        var param = command.Parameters.Add("ShoppingListID", SqlDbType.Int);
                        param.Direction = ParameterDirection.Output;
     
                        command.ExecuteNonQuery(); // no results coming back

                        shoppingListId = (int)param.Value;
                    }
                } // should close transaction here automatically

                // Create new ShoppingList obj
                slTemp = new ShoppingList(shoppingListId, shoppingListName);

                // Second: Use shoppingListId to create ShoppingListItems from recipes list
                foreach (Recipe r in recipes) // For each recipe
                {
                    foreach (KeyValuePair<Ingredient, int> kvp in r.MeasuredIngredients) // For each measured ingredient in recipe
                    {
                        int pantryItemId = kvp.Key.Id;
                        int pantryItemRecipeAmt = kvp.Value;
                        // Insert into ShoppingListItem Table
                        using (var transactionMulti = new TransactionScope())
                        {
                            using (var commandMulti = new SqlCommand("[dbo].CreateOrUpdateShoppingListItem", connection))
                            {
                                commandMulti.CommandType = CommandType.StoredProcedure;
                                commandMulti.Parameters.AddWithValue("PantryItemID", pantryItemId);
                                commandMulti.Parameters.AddWithValue("ShoppingListID", shoppingListId);
                                commandMulti.Parameters.AddWithValue("QuantityToPurchase", pantryItemRecipeAmt);

                                commandMulti.ExecuteNonQuery(); // no results coming back

                            }
                        } // should close transaction here automatically
                        // Add shoppingListItem to ShoppingList obj
                        slTemp.AddShoppingListItem(kvp.Key, pantryItemRecipeAmt);
                    }                 
                }
            } // should close connection here automatically
            return slTemp;

        }
    }
}
