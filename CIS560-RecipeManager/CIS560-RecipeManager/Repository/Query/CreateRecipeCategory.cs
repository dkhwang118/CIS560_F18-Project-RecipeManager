/*
 * CreateRecipeCategory.cs
 * partial Query class; includes the method to add a recipe category to the database
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
        public RecipeCategory CreateRecipeCategory(string categoryName)
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                using (var transaction = new TransactionScope())
                {
                    using (var command = new SqlCommand("dbo.CreateRecipeCategory", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("CategoryName", categoryName);
                        var param = command.Parameters.Add("CategoryID", SqlDbType.Int);
                        param.Direction = ParameterDirection.Output;

                        connection.Open();

                        command.ExecuteNonQuery(); // no results coming back

                        transaction.Complete();

                        return new RecipeCategory((int)param.Value, categoryName); // return an Ingredient object with the same data that has been written to the DB
                    }
                } // should close transaction here automatically
            } // should close connection here automatically
        }
    }  
}
