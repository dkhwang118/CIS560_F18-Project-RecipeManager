/*
 * UpdateIngredientQuantity.cs
 * partial Query class for the UpdateIngredientQuantity method
 */ 

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
        /// <summary>
        /// Updates the given ingredient with the given quantity in the PantryItem table
        /// </summary>
        /// <param name="quantity">Number of ingredient untis to be added/subtracted (positive/negative value) from PantryItem</param>
        /// <param name="ingredient">Ingredient to be Updated</param>
        public void UpdateIngredientQuantity(int quantity, Ingredient ingredient)
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                int currentQuantity;
                connection.Open();
                // First: Find current quantity of item in Pantry
                using (var transaction = new TransactionScope())
                {
                    using (var command = new SqlCommand("[dbo].FindPantryItemByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("ItemID", ingredient.Id);

                        var result = command.ExecuteReader();

                        if (result.HasRows)
                        {
                            result.Read();
                            currentQuantity = result.GetFieldValue<int>(2);
                        }
                        else
                        {
                            throw new NotImplementedException("Behavior for failed ingredient lookups has not been implemented yet");
                        }
                    }
                }
                connection.Close();

                connection.Open();
                // Quantity Check
                if ((currentQuantity + quantity) < 0)
                {
                    throw new Exception("Cannot update quantity in pantry to a negative value");
                }

                using (var transaction2 = new TransactionScope())
                {
                    using (var command2 = new SqlCommand("[dbo].UpdateIngredientQuantity", connection))
                    {
                        command2.CommandType = CommandType.StoredProcedure;
                        command2.Parameters.AddWithValue("PantryItemID", ingredient.Id);
                        command2.Parameters.AddWithValue("QuantityInPantry", (currentQuantity + quantity));

                        command2.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
