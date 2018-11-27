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
        private ICollection<ShoppingList> _shoppingLists;
        public Action<ICollection<Recipe>> GetShoppinglistDelegate;

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
            _shoppingLists = _queryRepository.GetAllShoppingLists();
        }

        public void LaunchShoppingListForm()
        {
            new uiShoppingList(LaunchAddShoppingListForm, LaunchShowShoppingListForm).Show();
        }

        public void LaunchAddShoppingListForm()
        {
            new uiAddShoppingList(_recipeInventory, GetShoppingList).Show();
        }

        public void GetShoppingList(ICollection<Recipe> recipes)
        {
            ShoppingList shoppingList = _queryRepository.GetShoppingList(recipes);
            _shoppingLists.Add(shoppingList);
        }

        public void LaunchShowShoppingListForm(ShoppingList currentShoppingList)
        {
            new uiShowShoppingList(currentShoppingList).Show();
        }

    }
}
