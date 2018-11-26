/*
 * CreateIngredient.cs
 * partial Query class to implement CreateIngredient() method
 */ 

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
        /// Creates an Ingredient from user parameters and updates the database
        /// NOTE: Updates the "PantryItem" Table; Does not create a RecipeIngredient
        /// </summary>
        /// <param name="ingredientName">Name of ingredient</param>
        /// <param name="unitOfMeasurement">Measurement unit to be used with ingredient in recipes</param>
        /// <param name="unitCount">Amount of ingredient currently held by user</param>
        /// <returns></returns>
        public Ingredient CreateIngredient(string ingredientName, string unitOfMeasurement, int unitCount)
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                using (var transaction = new TransactionScope())
                {
                    using (var command = new SqlCommand("[dbo].CreateIngredient", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("PantryItemName", ingredientName);
                        command.Parameters.AddWithValue("QuantityInPantry", unitCount);
                        command.Parameters.AddWithValue("ItemUnitMeasurement", unitOfMeasurement);
                        var param = command.Parameters.Add("PantryItemID", SqlDbType.Int);
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
