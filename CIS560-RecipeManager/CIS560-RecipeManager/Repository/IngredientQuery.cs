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
        public void CreateRecipeCategory(RecipeCategory category)
        {
            throw new NotImplementedException();
        }

        public void CookRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public Ingredient CreateIngredient(string ingredientName, string unitOfMeasurement, int unitCount)
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                using (var transaction = new TransactionScope())
                {
                    using (var command = new SqlCommand("dbo.AddIngredient", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("Name", ingredientName);
                        command.Parameters.AddWithValue("QuantityInPantry", unitCount);
                        command.Parameters.AddWithValue("UnitMeasurement", unitOfMeasurement);
                        var param = command.Parameters.Add("IngredientId", SqlDbType.Int);
                        param.Direction = ParameterDirection.Output;
                        command.ExecuteNonQuery(); // no results coming back
                        return new Ingredient((int)param.Value, ingredientName, unitOfMeasurement); // return an Ingredient object with the same data that has been written to the DB
                    }
                }
            }
        }

        public Recipe CreateRecipe(string recipeName, string recipeDescription, IDictionary<Ingredient, int> measuredIngredients)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecipeCategory(RecipeCategory category)
        {
            throw new NotImplementedException();
        }

        public ShoppingList GetShoppingList(ICollection<Recipe> recipes)
        {
            throw new NotImplementedException();
        }

        public void UpdateIngredientQuantity(int quantity, Ingredient ingredient)
        {
            throw new NotImplementedException();
        }
    }
}
