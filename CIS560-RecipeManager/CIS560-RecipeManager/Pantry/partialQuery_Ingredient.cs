/**
 * partialQuery_Ingredient.cs
 * partial Query class; specific to Adding Ingredients to the database
 * 
 * author: Project Team 1 - CIS 560 KSU Fall 2018
 * edited by: David K. Hwang
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace CIS560_RecipeManager.Pantry
{
    public partial class Query : IQuery
    {

        public TransactionScope Transaction;

        public SqlConnection Connection;

        public Query()
        {
            Transaction = new TransactionScope();
            Connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString);
        }

        /// <summary>
        /// Opens the connection to the database
        /// </summary>
        public void OpenConnection()
        {
            Connection.Open();
        }

        /// <summary>
        /// Closes the connection to the database
        /// </summary>
        public void CloseConnection()
        {
            Transaction.Complete();
            Connection.Close();
        }

        /// <summary>
        /// Adds an Ingredient to the Ingredient table using the defined parameters
        /// </summary>
        /// <param name="ingredientName">Name of the Ingredient</param>
        /// <param name="unitOfMeasurement">Unit of Measurement for the ingredient</param>
        /// <param name="unitCount">Number of initial units in pantry</param>
        /// <returns></returns>
        public Ingredient AddIngredient(string ingredientName, string unitOfMeasurement, int unitCount)
        {
            using (var command = new SqlCommand("dbo.AddIngredient", Connection))
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

        public void AddRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public void AddRecipeCategory(RecipeCategory category)
        {
            throw new NotImplementedException();
        }

        public void CookRecipe(Recipe recipe)
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

        public IReadOnlyCollection<Recipe> GetAvailableRecipes()
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
