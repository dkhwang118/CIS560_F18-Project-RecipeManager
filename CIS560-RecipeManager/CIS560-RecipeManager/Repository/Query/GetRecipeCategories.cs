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
        /// Gets all RecipeCategory information from the RecipeCategory table
        /// </summary>
        /// <returns>A list of RecipeCategory objects retrieved from the DB</returns>
        public ICollection<RecipeCategory> GetRecipeCategories()
        {
            ICollection<RecipeCategory> recipeCategoryList = new List<RecipeCategory>();

            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                using (var transaction = new TransactionScope())
                {
                    using (var command = new SqlCommand("[dbo].GetAllRecipeCategories", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();
                        var result = command.ExecuteReader();

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                recipeCategoryList.Add(new RecipeCategory(result.GetFieldValue<int>(0), result.GetFieldValue<string>(1)));
                            }
                        }

                    }
                }
            }
            return recipeCategoryList;
        }
    }
}
