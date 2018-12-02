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
            ShoppingLists.Add(_query.CreateShoppingList(name, recipes));
        }

        public void UpdateIngredients(ShoppingList shoppingList)
        {
            foreach(KeyValuePair<Ingredient, int> ingred in shoppingList.ShoppingListItems)
            {
                _query.UpdateIngredientQuantity(ingred.Value, ingred.Key);
            }
        }
    }
}
