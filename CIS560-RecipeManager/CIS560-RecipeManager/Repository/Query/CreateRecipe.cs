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
        /// Creates a recipe from user input
        /// NOTE: Recipe Category MUST BE CREATED/STORED IN DB FIRST before invoking this method
        /// NOTE: Measured Ingredients List MUST BE CREATED FIRST before invoking
        /// </summary>
        /// <param name="recipeName"></param>
        /// <param name="recipeDescription"></param>
        /// <param name="category"></param>
        /// <param name="measuredIngredients"></param>
        /// <returns></returns>
        public Recipe CreateRecipe(string recipeName, string recipeDescription, RecipeCategory category, IDictionary<Ingredient, int> measuredIngredients)
        {
            int recipeID;

            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                // First Transaction to Add the Recipe to the Recipe Table; Also creates valid RecipeID for RecipeIngredient Table
                using (var transaction = new TransactionScope())
                {
                    using (var command = new SqlCommand("dbo.CreateRecipe", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("RecipeName", recipeName);
                        command.Parameters.AddWithValue("RecipeDescription", recipeDescription);
                        command.Parameters.AddWithValue("CategoryID", category.Id);
                        var param = command.Parameters.Add("RecipeID", SqlDbType.Int);
                        param.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery(); // no results coming back

                        transaction.Complete();

                        recipeID = (int)param.Value;
                        //return new Recipe((int)param.Value, recipeName, recipeDescription, category, measuredIngredients); // return an Ingredient object with the same data that has been written to the DB
                    }
                } // should close transaction here automatically

                // Second Transaction: Add recipe ingredients from measuredIngredients to RecipeIngredient Table             
                // Loop over measuredIngredients to add each ingredient individually
                foreach (KeyValuePair<Ingredient, int> kvp in measuredIngredients)
                {
                    //using individual transactions for each ingredient; hoping this is less buggy than one transaction for the entire list
                    using (var transactionMulti = new TransactionScope())
                    {
                        using (var command2 = new SqlCommand("dbo.AddRecipeIngredient", connection))
                        {
                            command2.CommandType = CommandType.StoredProcedure;
                            command2.Parameters.AddWithValue("PantryItemID", kvp.Key.Id);
                            command2.Parameters.AddWithValue("RecipeID", recipeID);
                            command2.Parameters.AddWithValue("RecipeQuantity", kvp.Value);

                            command2.ExecuteNonQuery();

                        }
                        transactionMulti.Complete();
                    }
                }
                    
                return new Recipe(recipeID, recipeName, recipeDescription, category, measuredIngredients); // return an Ingredient object with the same data that has been written to the DB
            } // should close connection here automatically
        }
    }
}
