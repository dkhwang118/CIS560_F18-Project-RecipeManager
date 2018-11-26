/*
 * UpdateRecipe.cs
 * partial Query class for UpdateRecipe Method
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
        /// Update a Recipe and its Ingredients in the DB from a given recipe
        /// NOTE: DOES NOT create a new RecipeId; As is, recipeId from given parameter must match the recipeId you are updating
        /// </summary>
        /// <param name="recipe">Recipe to be updated; Includes the old recipeId w/ new values</param>
        public void UpdateRecipe(Recipe recipe)
        {
            // Before changing the DB, check if measuredIngredients list needs changes
            bool recipeIngredientsChanged = false;
            if (ReadRecipe(recipe.Id).MeasuredIngredients != recipe.MeasuredIngredients) recipeIngredientsChanged = true;


            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                connection.Open();
                // First Transaction: Update Recipe in Recipe Table
                using (var transaction = new TransactionScope())
                {
                    using (var command = new SqlCommand("dbo.UpdateRecipeInRecipeTable", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("RecipeID", recipe.Id);
                        command.Parameters.AddWithValue("RecipeName", recipe.Name);
                        command.Parameters.AddWithValue("RecipeDescription", recipe.Description);
                        command.Parameters.AddWithValue("CategoryID", recipe.Category.Id);

                        command.ExecuteNonQuery();
                    }
                }

                if (recipeIngredientsChanged)
                {
                    // Second Transaction: Delete All RecipeIngredients associated w/ old recipe
                    using (var transaction2 = new TransactionScope())
                    {
                        using (var command2 = new SqlCommand("dbo.DeleteRecipeIngredientsByRecipeId", connection))
                        {
                            command2.CommandType = CommandType.StoredProcedure;
                            command2.Parameters.AddWithValue("RecipeID", recipe.Id);

                            command2.ExecuteNonQuery();
                        }
                    }

                    // Third Transaction: Repopulate RecipeIngredients Table w/ new measuredIngredients List
                    foreach (KeyValuePair<Ingredient, int> kvp in recipe.MeasuredIngredients)
                    {
                        using (var transactionMulti = new TransactionScope())
                        {
                            using (var commandMulti = new SqlCommand("dbo.AddRecipeIngredient", connection))
                            {
                                commandMulti.CommandType = CommandType.StoredProcedure;
                                commandMulti.Parameters.AddWithValue("PantryItemID", kvp.Key.Id);
                                commandMulti.Parameters.AddWithValue("RecipeID", recipe.Id);
                                commandMulti.Parameters.AddWithValue("RecipeQuantity", kvp.Value);

                                commandMulti.ExecuteNonQuery();
                            }
                        }

                    }

                }
            } // connection closes here
        }
    }
}
