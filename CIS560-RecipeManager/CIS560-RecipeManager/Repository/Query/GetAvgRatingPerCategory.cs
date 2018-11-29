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
        /// Gets the average rating of all rated recipes (recipeRating != NULL) in each category
        /// </summary>
        /// <returns>Dictionary with kvp = RecipeCategory object: AverageRecipeRatingWithinCategory</returns>
        IDictionary<RecipeCategory, decimal> GetAvgRatingPerCategory()
        {
            Dictionary<RecipeCategory, decimal> returnDict = new Dictionary<RecipeCategory, decimal>();
            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                using (var transaction = new TransactionScope())
                {
                    connection.Open();
                    using (var command = new SqlCommand("[dbo].GetAvgRatingPerCategory", connection))
                    { 
                        command.CommandType = CommandType.StoredProcedure;

                        // simple read; no params
                        var result = command.ExecuteReader();

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                returnDict.Add(new RecipeCategory(result.GetFieldValue<int>(0), result.GetFieldValue<string>(1)),
                                                                    result.GetFieldValue<decimal>(2));
                            }
                               
                        }
                        else
                        {
                            throw new Exception("Query returned no results!");
                        }
                        
                        // Close reader to prevent DB issues; reader doesn't seem to automatically close upon closing the transaction
                        result.Close(); 
                    }
                    connection.Close();
                }
            }

            return returnDict;
        }
    }
}
