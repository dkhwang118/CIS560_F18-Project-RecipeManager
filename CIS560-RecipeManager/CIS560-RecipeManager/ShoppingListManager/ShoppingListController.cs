using CIS560_RecipeManager.RecipeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_RecipeManager.ShoppingListManager
{
    public class ShoppingListController
    {
        private List<ShoppingList> _shoppingLists;
        public delegate ShoppingList GetShoppinglistDelegate(ICollection<Recipe> recipes);
        private IQuery _queryRepository;
        private MyPantry _pantry;
        private RecipeInventory _recipeInventory;
        
        public ShoppingListController(
            IQuery query,
            MyPantry pantry,
            RecipeInventory recipeInventory)
        {
            _queryRepository = query;
            _pantry = pantry;
            _recipeInventory = recipeInventory;
        }

        public void LaunchShoppingListForm()
        {
            new uiShoppingList(LaunchAddShoppingListForm, LaunchShowShoppingListForm).Show();
        }

        public void LaunchAddShoppingListForm()
        {
            new uiAddShoppingList(_recipeInventory, GetShoppingList).Show();
        }

        public ShoppingList GetShoppingList(ICollection<Recipe> recipes)
        {
            ShoppingList shoppingList = _queryRepository.CreateShoppingList("ShoppingListName", recipes); // Need to pass a string value here to name the shopping list
            _shoppingLists.Add(shoppingList);
            return shoppingList;
        }

        public void LaunchShowShoppingListForm()
        {
            new uiShowShoppingList().Show();
        }

    }
}
