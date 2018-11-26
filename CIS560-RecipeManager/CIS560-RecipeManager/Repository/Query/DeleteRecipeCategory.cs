/*
 * DeleteRecipeCategory.cs
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
        /// <summary>
        /// Deletes a RecipeCategory from the RecipeCategory table
        /// NOTE: Does not check for recipies that are currently associated with the category to be deleted
        /// </summary>
        /// <param name="recipeCategory">Category to be deleted from the DB</param>
        public void DeleteRecipeCategory(RecipeCategory recipeCategory)
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                using (var transaction = new TransactionScope())
                {
                    using (var command = new SqlCommand("[dbo].DeleteRecipeCategoryById", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("CategoryID", recipeCategory.Id);
    
                        connection.Open();

                        command.ExecuteNonQuery(); // no results coming back

                        transaction.Complete();

                    }
                } // should close transaction here automatically
            } // should close connection here automatically
        }
    }
}
