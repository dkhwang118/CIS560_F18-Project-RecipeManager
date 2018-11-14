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
        public Recipe CreateRecipe(string recipeName, string recipeDescription, int categoryId, IDictionary<Ingredient, int> measuredIngredients)
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

                        connection.Open();

                        command.ExecuteNonQuery(); // no results coming back

                        transaction.Complete();

                        return new Ingredient((int)param.Value, ingredientName, unitOfMeasurement); // return an Ingredient object with the same data that has been written to the DB
                    }
                } // should close transaction here automatically
            } // should close connection here automatically
        }
    }
}
