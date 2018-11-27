/*
 * RateRecipe.cs
 * partial Query class; holds the method to change recipe ratings in the DB
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
        public void RateRecipe(Recipe recipe, int recipeRating)
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                using (var transaction = new TransactionScope())
                {
                    using (var command = new SqlCommand("[dbo].RateRecipe", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("RecipeID", recipe.Id);
                        command.Parameters.AddWithValue("RecipeRating", recipeRating);

                        connection.Open();

                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
