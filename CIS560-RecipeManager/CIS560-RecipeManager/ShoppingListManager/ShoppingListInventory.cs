using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_RecipeManager.RecipeManager;

namespace CIS560_RecipeManager.ShoppingListManager
{
    public class ShoppingListInventory
    {
        private IQuery _query;

        public BindingList<ShoppingList> ShoppingLists { get; }

        public ShoppingListInventory(IQuery query)
        {
            _query = query;
            ShoppingLists = new BindingList<ShoppingList>();
            GetAllShoppingLists();
        }

        public void GetAllShoppingLists()
        {
            var lists = _query.GetAllShoppingLists();
            foreach (var l in lists)
            {
                ShoppingLists.Add(l);
            }
        }

        public void CreateShoppingList(string name, ICollection<Recipe> recipes)
        {
            ShoppingList result;
            try
            {
                result = _query.CreateShoppingList(name, recipes);
            }
            catch (System.Data.SqlClient.SqlException)
            {
                System.Windows.Forms.MessageBox.Show($"Error, a shopping list with the name \"{name}\" already exists. Shopping List was not created.");
                return;
            }
            ShoppingLists.Add(_query.CreateShoppingList(name, recipes));
        }
    }
}
