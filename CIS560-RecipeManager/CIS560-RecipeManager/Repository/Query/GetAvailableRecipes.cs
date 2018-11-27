using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using CIS560_RecipeManager.RecipeManager;

namespace CIS560_RecipeManager.Repository
{
    public partial class Query : IQuery
    {
        public IReadOnlyCollection<Recipe> GetAvailableRecipes()
        {
            List<int> recipeIDs = new List<int>();
            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                using (var transaction = new TransactionScope())
                {

                    connection.Open();

                    int id;
                    String name;
                    int quantity;
                    string description;
                    int categoryID;

                    using (var command = new SqlCommand(@"
SELECT R.RecipeID
FROM[dbo].[Recipes] R
-- I would prefer for a way to check forall x.P(x) rather than not exists x.not p(x).
WHERE NOT EXISTS
   (
      SELECT 1

      FROM[dbo].RecipeIngredient RI

        JOIN[dbo].PantryItem[PI] ON RI.PantryItemID = [PI].PantryItemID

      WHERE R.RecipeID = RI.RecipeID

        AND[PI].QuantityInPantry < RI.RecipeQuantity
   )", connection))
                    {

                        var result = command.ExecuteReader();
                        
                        // I don't believe that checking for result.HasRows is needed in this use-case.
                        while (result.Read())
                        {
                            id = result.GetFieldValue<int>(0);
                            recipeIDs.Add(id);
                        }
                    }

                    connection.Close();
                }
            }
            return recipeIDs.Select(i => ReadRecipe(i)).ToList();
        }
    }
}
