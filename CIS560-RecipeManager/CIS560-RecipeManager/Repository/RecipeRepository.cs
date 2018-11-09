using CIS560_RecipeManager.RecipeManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace CIS560_RecipeManager
{
    public class RecipeRepository
    {
        string connectionString = Properties.Settings.Default.RecipeDatabaseConnectionString;

        public Recipe CreateRecipe(string recipeName, string recipeDesc)
        {
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("dbo.CreateRecipe", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure; // read var command as a stored procedure

                        command.Parameters.AddWithValue("RecipeName", recipeName);

                        command.Parameters.AddWithValue("RecipeDescription", recipeDesc);

                        command.Parameters.AddWithValue("CategoryID", 1); // CategoryID value of "1" until Category Table is setup to allow creation of new categories

                        var param = command.Parameters.Add("RecipeID", SqlDbType.Int);
                        param.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery(); // no result set coming back

                        transaction.Complete();

                        return new Recipe((int)param.Value, recipeName);
                    }
                }
            }
        }

        public Recipe GetRecipe(int recipeID)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Recipe> GetRecipeList()
        {
            throw new NotImplementedException();
        }
    }
}
