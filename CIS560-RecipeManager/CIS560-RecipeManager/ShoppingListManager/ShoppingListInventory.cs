using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_RecipeManager.RecipeManager;

namespace CIS560_RecipeManager.ShoppingListManager
{
    public class ShoppingListInventory
    {
        private IQuery _query;
        private ICollection<ShoppingList> _shoppingLists;

        public ShoppingListInventory(IQuery query)
        {
            _query = query;
            GetAllShoppingLists();
        }

        public void GetAllShoppingLists()
        {
            _shoppingLists = _query.GetAllShoppingLists();
        }

        public void CreateShoppingList(string name, ICollection<Recipe> recipes)
        {
            _shoppingLists.Add(_query.CreateShoppingList(name, recipes));
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
