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
        public ICollection<Recipe> GetAllRecipes()
        {
            var ids = getAllRecipeIds();
            var recipes = new List<Recipe>();
            foreach (var id in ids)
            {
                recipes.Add(ReadRecipe(id));
            }
            return recipes;
        }

        private ICollection<int> getAllRecipeIds()
        {
            ICollection<int> ids = new List<int>();

            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                using (var transaction = new TransactionScope())
                {
                    using (var command = new SqlCommand("[dbo].GetAllRecipeIDs", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();
                        var result = command.ExecuteReader();

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                ids.Add(result.GetFieldValue<int>(0));
                            }
                        }

                    }
                }
            }
            return ids;
        }
    }
}
