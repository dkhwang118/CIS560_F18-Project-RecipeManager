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
        /// Subtracts the ingredient(s) quantity as defined by the given recipe from the PantryItem Table
        /// </summary>
        /// <param name="recipe">Recipe to "Cook"</param>
        public void CookRecipe(Recipe recipe)
        {
            // Loop through each ingredient and update quantity
            foreach (KeyValuePair<Ingredient, int> kvp in recipe.MeasuredIngredients)
            {
                // Get Ingredient's Current Quantity in Pantry
                int currentQuantity;
                using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
                {
                    using (var transaction = new TransactionScope())
                    {
                        connection.Open();
                        using (var command = new SqlCommand("[dbo].FindPantryItemByID", connection))
                        {
                            // Finds a row in the table using
                            // https://docs.microsoft.com/en-us/visualstudio/data-tools/query-datasets?view=vs-2015#to-find-a-row-in-an-untyped-dataset-with-a-primary-key-value
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("ItemID", kvp.Key.Id);

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
                            result.Close();
                        }
                        connection.Close();
                    }
                }

                UpdateIngredientQuantity((currentQuantity - kvp.Value), kvp.Key); // subtract the quantity given by recipe from the ingredient quantity in pantry
            }

            // Update RecipesCookedDates table
            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                using (var transaction = new TransactionScope())
                {
                    using (var command = new SqlCommand("[dbo].UpdateRecipesCookedDates", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("RecipeID", recipe.Id);

                        connection.Open();

                        command.ExecuteNonQuery(); // no results coming back
                    }
                } // should close transaction here automatically
            } // should close connection here automatically

        }
    }
}
