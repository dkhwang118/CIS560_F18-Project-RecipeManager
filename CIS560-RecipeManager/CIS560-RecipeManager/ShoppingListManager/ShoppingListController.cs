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
        //private ICollection<ShoppingList> _shoppingLists = new List<ShoppingList>();
        //public Action<string, ICollection<Recipe>> GetShoppinglistDelegate;
        //public Action<ShoppingList> GoShoppingDelegate;
        private ShoppingListInventory _shoppingInventory;
        private MyPantry _pantry;
        private RecipeInventory _recipeInventory;
        public ShoppingListController(
            ShoppingListInventory shoppingListInventory,
            MyPantry pantry, RecipeInventory recipeInventory)
        {
            _shoppingInventory = shoppingListInventory;
            _pantry = pantry;
            _recipeInventory = recipeInventory;
            //_shoppingLists = _queryRepository.GetAllShoppingLists();
        }
        public void LaunchShoppingListForm()
        {
            new uiShoppingList(LaunchAddShoppingListForm, LaunchShowShoppingListForm, _shoppingInventory).Show();
        }

        public void LaunchAddShoppingListForm(string name, ICollection<Recipe> recipes)
        {
            new uiAddShoppingList(_shoppingInventory.CreateShoppingList, _recipeInventory, recipes, _shoppingInventory).Show();
        }

        //public void GetShoppingList(string name, ICollection<Recipe> recipes)
        //{
        //    ShoppingList shoppingList = _queryRepository.CreateShoppingList(name, recipes);
        //    _shoppingLists.Add(shoppingList);
        //}

        public void LaunchShowShoppingListForm(ShoppingList currentShoppingList)
        {
            new uiShowShoppingList(currentShoppingList).Show();
        }

        //public void GoShopping(ShoppingList list)
        //{
        //    foreach(KeyValuePair<Ingredient, int> ingred in list.ShoppingListItems)
        //    {
        //        _queryRepository.UpdateIngredientQuantity(ingred.Value, ingred.Key);
        //    }
        //}

    }
}
