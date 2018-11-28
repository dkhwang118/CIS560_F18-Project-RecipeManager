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
        public ICollection<ShoppingList> GetAllShoppingLists()
        {
            IDictionary<int, ShoppingList> retList = new Dictionary<int, ShoppingList>();
            List<int[]> shoppingListItems = new List<int[]>();
            using (var connection = new SqlConnection(Properties.Settings.Default.RecipeDatabaseConnectionString))
            {
                connection.Open();
                // Get all shoppingListID's and their names
                using (var transaction = new TransactionScope())
                {
                    using (var command = new SqlCommand("[dbo].GetAllShoppingLists", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        var result = command.ExecuteReader();

                        if (result.HasRows)
                        {
                            int curShopListID;
                            string curShopListName;
                            while (result.Read())
                            {
                                curShopListID = result.GetFieldValue<int>(0);
                                curShopListName = result.GetFieldValue<string>(1);

                                // add to retList
                                retList.Add(curShopListID, new ShoppingList(curShopListID, curShopListName));
                            }
                        }
                    }
                } // end current transaction


                // Get all ShoppingListItems and place data into list
                using (var transaction2 = new TransactionScope())
                {
                    using (var command2 = new SqlCommand("[dbo].GetAllShoppingListItems", connection))
                    {
                        command2.CommandType = CommandType.StoredProcedure;

                        var result = command2.ExecuteReader();

                        if (result.HasRows)
                        {
                            while (result.Read())
                            {
                                curShopListID = result.GetFieldValue<int>(1);
                                shoppingListItems.Add(new int[3]{curShopListID, // shoppingListID first for ease of search
                                                                 result.GetFieldValue<int>(0), // then PantryItemID
                                                                 result.GetFieldValue<int>(2) });   // finally, quantity of pantryItem in shopping list

                                if (numberOfShoppingLists < curShopListID) numberOfShoppingLists = curShopListID;
                            }
                        }
                    }
                } // end current transaction
            } // close connection and then do calculations

            // for every shopping list
            for (int i = 1; i < (numberOfShoppingLists+1); i++)
            {
                ShoppingList tempSL = new ShoppingList()
                // search through each item and add when matched with current list
                foreach (int[] slItem in shoppingListItems)
                {

                }
            }
            

        }

    }
}
