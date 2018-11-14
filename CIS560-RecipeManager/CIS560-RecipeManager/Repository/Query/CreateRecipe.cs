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
        public Recipe CreateRecipe(string recipeName, string recipeDescription, int categoryId, IDictionary<Ingredient, int> measuredIngredients)
        {

            Recipe retRecipe; // recipe object to be returned after all transactions are complete
            int recipeID;

            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                // Connection values stay the same, but individual transactions must be done in order to add values to all relevant tables

                // First transaction: Add Recipe to Recipes table
                using (var transaction = new TransactionScope())
                {
                    using (var command = new SqlCommand("dbo.CreateRecipe", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("RecipeName", recipeName);
                        command.Parameters.AddWithValue("RecipeDescription", recipeDescription);
                        command.Parameters.AddWithValue("CategoryID", categoryId);
                        var param = command.Parameters.Add("RecipeID", SqlDbType.Int);
                        param.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery(); // no results coming back
                        recipeID = (int)param.Value; // save catID for Linking ingredients in next step

                        transaction.Complete();

                        retRecipe = new Recipe((int)param.Value, recipeName, recipeDescription, measuredIngredients); // return an Ingredient object with the same data that has been written to the DB
                    }
                } // should close transaction here automatically

                // Second Transaction: Link Ingredients in measuredIngredients to RecipeID and add them to RecipeIngredient Table
                using (var transaction = new TransactionScope()) // second transaction; connection should be ok left open
                {
                    foreach (KeyValuePair<Ingredient, int> kvp in measuredIngredients)
                    {
                        using (var command = new SqlCommand("dbo.AddRecipeIngredient", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("PantryItemID", kvp.Key.Id);
                            command.Parameters.AddWithValue("RecipeID", recipeID);
                            command.Parameters.AddWithValue("RecipeQuantity", kvp.Value);

                            command.ExecuteNonQuery();
                        }
                    }

                    transaction.Complete(); // we'll see if we can execute the queries without needing to do separate transactions




                } // should close connection here automatically
               
            }
            return retRecipe;
        }
    }
}
