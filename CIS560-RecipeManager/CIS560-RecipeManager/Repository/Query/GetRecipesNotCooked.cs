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
        public ICollection<Recipe> GetRecipesNotCooked()
        {
            List<Recipe> returnList = new List<Recipe>();
            List<int> recipeIDs = new List<int>();
            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                connection.Open();

                // first, get all recipe ID's and LastDateCooked strings to build recipe objects in second transaction
                using (var transaction = new TransactionScope())
                {
                    using (var command = new SqlCommand("[dbo].GetRecipesNotCooked", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        var result = command.ExecuteReader();

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                recipeIDs.Add(result.GetFieldValue<int>(0));

                            }
                        }
                        else
                        {
                            throw new Exception("No results returning from query; Have all the recipes been cooked at least once?");
                        }
                        // Close reader to prevent DB exceptions
                        result.Close();
                    }
                } // should close transaction here automatically
                connection.Close();
            } // close connection

            foreach (int rID in recipeIDs)
            {
                returnList.Add(ReadRecipe(rID));
            }

            return returnList;
        }
    }
}
