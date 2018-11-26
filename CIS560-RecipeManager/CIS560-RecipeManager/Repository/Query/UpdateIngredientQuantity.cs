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
        /// <param name="quantity">New Quantity of Ingredient in PantyItem Table</param>
        /// <param name="ingredient">Ingredient to be Updated</param>
        public void UpdateIngredientQuantity(int quantity, Ingredient ingredient)
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                using (var transaction = new TransactionScope())
                {
                    using (var command = new SqlCommand("UpdateIngredientQuantity", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("PantryItemID", ingredient.Id);
                        command.Parameters.AddWithValue("QuantityInPantry", quantity);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
