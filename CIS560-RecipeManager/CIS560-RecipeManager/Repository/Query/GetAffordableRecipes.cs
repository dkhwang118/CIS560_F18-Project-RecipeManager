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
        /// Gets all recipes from PantryItem Table that can be cooked given current PantryItem quantities and max amount allowed to spend
        /// </summary>
        /// <param name="maxAmtToSpendInCents">Maximum amount allowed to be spent on any given recipe</param>
        /// <returns>List of Recipe objects that can be cooked given the amount allowed to be spent acquiring additional PantryItems </returns>
        public ICollection<Recipe> GetAffordableRecipes(int maxAmtToSpendInCents)
        {
            List<Recipe> returnList = new List<Recipe>();
            List<int> affordableRecipeIds = new List<int>(); 
            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                using (var transaction = new TransactionScope())
                {
                    connection.Open();
                    using (var command = new SqlCommand("[dbo].GetAffordableRecipes", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("MaxMoneyToSpendInCents", maxAmtToSpendInCents);

                        var result = command.ExecuteReader();

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                // Add RecipeID to list build list once this connection is closed
                                affordableRecipeIds.Add(result.GetFieldValue<int>(0));
                            }
                        }
                        else
                        {
                            throw new Exception("No Affordable Recipes Found!");
                        }
                        result.Close();
                    }              
                }

                // Loop through list and add recipes to returnList
                foreach (int recipeID in affordableRecipeIds)
                {
                    returnList.Add(ReadRecipe(recipeID));
                }
                return returnList;
            }
        }
    }
}
