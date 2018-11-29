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
        /// Returns a List of the top rated recipes in each category; number of recipes per category is determined by parameter value
        /// </summary>
        /// <param name="recipesPerCategory">Number of recipes per category returned</param>
        /// <returns>List of top rated recipes per each category</returns>
        public ICollection<Recipe> GetTopRatedRecipesWithTies(int recipesPerCategory)
        {
            List<Recipe> returnList = new List<Recipe>();
            List<int> topRatedRecipeIDs = new List<int>();
            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                using (var transaction = new TransactionScope())
                {
                    connection.Open();
                    using (var command = new SqlCommand("[dbo].GetTopRatedRecipesPerCategoryWithTies", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("RecipesPerCategory", recipesPerCategory);

                        var result = command.ExecuteReader();

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                // Add RecipeID to list build list once this connection is closed
                                topRatedRecipeIDs.Add(result.GetFieldValue<int>(2));
                            }
                        }
                        else
                        {
                            throw new Exception("Query returned no results");
                        }
                        result.Close();
                    }
                }
            } // close connection and start building Recipe List

            // for-loop to preserve list order
            for (int i = 0; i < topRatedRecipeIDs.Count; i++)
            {
                returnList.Add(ReadRecipe(topRatedRecipeIDs[i]));
            }

            return returnList;

        }
    }
}
