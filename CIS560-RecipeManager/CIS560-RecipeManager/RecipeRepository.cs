using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace CIS560_RecipeManager
{
    public class RecipeRepository : IRecipeRepository
    {
        string connectionString = Properties.Settings.Default.RecipeDatabaseConnectionString;

        public Recipe CreateRecipe(string recipeName)
        {
            using (var transaction = new TransactionScope())
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    using (var command = new SqlCommand("RecipeDefaultDataSet.CreateRecipe", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure; // read var command as a stored procedure

                        command.Parameters.AddWithValue("RecipeName", recipeName);

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
