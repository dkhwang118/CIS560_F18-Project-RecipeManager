/*
 * CookRecipe.cs
 * partial Query class holding the CookRecipe method
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
        /// Returns how many times a recipe can be cooked with current pantry.
        /// </summary>
        /// <param name="recipe">Recipe to compute the number of times it can be cooked</param>
        public int NumberMakeable(Recipe recipe)
        {
            // Get Ingredient's Current Quantity in Pantry
            int times;
            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                using (var transaction = new TransactionScope())
                {
                    connection.Open();
                    using (var command = new SqlCommand("[dbo].NumberMakeable", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("RecipeID", recipe.Id);

                        var result = command.ExecuteReader();

                        if (result.HasRows)
                        {
                            result.Read();
                            times = result.GetFieldValue<int>(0);
                        }
                        else
                        {
                            throw new NotImplementedException("Behavior for failed ingredient lookups has not been implemented yet");
                        }
                        result.Close();
                    }
                    connection.Close();
                }
            }
            return times;
        }
    }
}
