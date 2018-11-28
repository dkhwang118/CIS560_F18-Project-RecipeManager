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
        public Ingredient ReadIngredient(int ingredientId)
        {
            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                using (var transaction = new TransactionScope())
                {
                    connection.Open();
                    Ingredient ingredient;
                    using (var command = new SqlCommand("[dbo].FindPantryItemByID", connection))
                    {
                        // Finds a row in the table using
                        // https://docs.microsoft.com/en-us/visualstudio/data-tools/query-datasets?view=vs-2015#to-find-a-row-in-an-untyped-dataset-with-a-primary-key-value
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("ItemID", ingredientId);

                        var result = command.ExecuteReader();

                        int id;
                        String name;
                        int quantity;
                        String unit;
                        int price;

                        if (result.HasRows)
                        {
                            result.Read();
                            id = result.GetFieldValue<int>(0);
                            name = result.GetFieldValue<String>(1);
                            quantity= result.GetFieldValue<int>(2);
                            unit = result.GetFieldValue<String>(3);
                            price = result.GetFieldValue<int>(4);

                            ingredient = new Ingredient(id, name, unit, price);
                        }
                        else
                        {
                            throw new NotImplementedException("Behavior for failed ingredient lookups has not been implemented yet");
                        }
                    }

                    connection.Close();
                    return ingredient;
                }
            }
        }
    }
}
