/*
 * DeleteRecipe.cs
 * partial Query class for the DeleteRecipe Method
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
        /// Deletes the given recipe from the Recipes Table, and the associated Ingredients from RecipeIngredient Table
        /// </summary>
        /// <param name="recipe">Recipe to be deleted from DB</param>
        public void DeleteRecipe(Recipe recipe)
        {

            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                connection.Open();
                // First, delete associated ingredients from RecipeIngredient Table
                using (var transaction = new TransactionScope())
                {
                    using (var command = new SqlCommand("[dbo].DeleteRecipeIngredientsByRecipeId", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("RecipeID", recipe.Id);

                        command.ExecuteNonQuery();
                    }
                }

                // Second, delete recipe from Recipes Table
                using (var transaction2 = new TransactionScope())
                {
                    using (var command2 = new SqlCommand("[dbo].DeleteRecipeById", connection))
                    {
                        command2.CommandType = CommandType.StoredProcedure;
                        command2.Parameters.AddWithValue("RecipeID", recipe.Id);

                        command2.ExecuteNonQuery();
                    }
                }

            } // connection closes here
        }
    }
}
