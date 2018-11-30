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

        public Recipe ReadRecipe(int recipeId)
        {
            String name;
            int quantity;
            string description;
            int categoryID;
            int? rating = null;
            IDictionary<int, int> measuredIngredientIDs = new Dictionary<int, int>();
            IDictionary<Ingredient, int> measuredIngredients = new Dictionary<Ingredient, int>();

            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                using (var transaction = new TransactionScope())
                {

                    connection.Open();


                    using (var command = new SqlCommand("[dbo].FindRecipeItemByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("ItemID", recipeId);

                        var result = command.ExecuteReader();
                        
                        if (result.HasRows)
                        {
                            result.Read();
                            name = result.GetFieldValue<string>(1);
                            description = result.GetFieldValue<string>(2);
                            categoryID = result.GetFieldValue<int>(3);
                            if (!result.IsDBNull(4))
                            {
                                rating = result.GetFieldValue<int?>(4);
                            }
                        }
                        else
                        {
                            throw new NotImplementedException("Behavior for failed recipe lookups has not been implemented yet");
                        }
                    }

                    // TODO: Reduce the sillyness of the procedure lines and the closing and immediate opening.
                    connection.Close();
                    connection.Open();

                    using (var command = new SqlCommand("DROP PROCEDURE IF EXISTS [dbo].FindRecipeIngredientInfoByID", connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                    connection.Open();

                    using (var command = new SqlCommand("CREATE PROCEDURE [dbo].FindRecipeIngredientInfoByID @ItemID int AS SELECT ri.RecipeID, ri.PantryItemID, ri.RecipeQuantity FROM RecipeIngredient ri WHERE ri.RecipeID = @ItemID", connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    connection.Close();

                    connection.Open();


                    using (var command = new SqlCommand("[dbo].FindRecipeIngredientInfoByID", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("ItemID", recipeId);

                        var result = command.ExecuteReader();
                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                int ingredientID = result.GetFieldValue<int>(1);
                                int ingredientQuantity = result.GetFieldValue<int>(2);

                                // store the ids for later because we can only have one connection to the db at a time
                                // and if we try to load the ingredients in full, we will hang here while the ingredient
                                // waits for the recipe loader to give up the connection.
                                measuredIngredientIDs[ingredientID] = ingredientQuantity;
                            }
                        }
                        else
                        {
                            throw new NotImplementedException("Behavior for failed recipe ingredient lookups has not been implemented yet");
                        }
                    }

                    connection.Close();

                    
                }
            }
            // Now that the connection is closed, we may do further ingredient lookups.
            foreach (var ingredientID in measuredIngredientIDs)
            {
                Ingredient ingredient = ReadIngredient(ingredientID.Key);
                measuredIngredients[ingredient] = ingredientID.Value;
            }

            Recipe recipe = new Recipe(recipeId, name, description, GetRecipeCategory(recipeId), measuredIngredients,rating);
            return recipe;
        }
    }
}
