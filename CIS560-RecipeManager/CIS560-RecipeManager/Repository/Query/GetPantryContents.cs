using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;

namespace CIS560_RecipeManager.Repository
{
    public partial class Query : IQuery
    {
        public IDictionary<Ingredient,int> GetPantryContents()
        {
           var ingredients = new Dictionary<Ingredient,int>();

            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                using (var transaction = new TransactionScope())
                {
                    using (var command = new SqlCommand("[dbo].GetAllIngredients", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        connection.Open();
                        var result = command.ExecuteReader();

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                ingredients.Add(new Ingredient(
                                    result.GetFieldValue<int>(0), 
                                    result.GetFieldValue<string>(1),
                                    result.GetFieldValue<string>(3)),
                                        result.GetFieldValue<int>(2));
                            }
                        }

                    }
                }
            }
            return ingredients;
        }
    }
}
