using CIS560_RecipeManager.RecipeManager;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CIS560_RecipeManager.Repository
{
    public partial class Query : IQuery
    {
        public RecipeCategory GetRecipeCategory(int recipeId)
        {
            RecipeCategory category;

            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                using (var transaction = new TransactionScope())
                {

                    connection.Open();
                    using (var command = new SqlCommand("[dbo].GetRecipeCategory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("recipeID", recipeId);
                        var result = command.ExecuteReader();

                        if (result.HasRows)
                        {
                            result.Read();
                            category = new RecipeCategory(result.GetFieldValue<int>(0), result.GetFieldValue<string>(1));
                        }
                        else
                        {
                            throw new ArgumentException($"The recipeID: {recipeId}, does not exist in the the database.");
                        }
                    }
                    connection.Close();
                    return category;
                }
            }
            return category;
        }
    }
}
