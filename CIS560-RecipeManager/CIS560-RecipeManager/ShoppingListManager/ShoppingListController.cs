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
        private ICollection<ShoppingList> _shoppingLists = new List<ShoppingList>();
        public Action<string, ICollection<Recipe>> GetShoppinglistDelegate;
        public Action<ShoppingList> GoShoppingDelegate;
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
            new uiShoppingList(LaunchAddShoppingListForm, LaunchShowShoppingListForm, _shoppingLists, GoShoppingDelegate).Show();
        }

        public void LaunchAddShoppingListForm()
        {
            new uiAddShoppingList(_recipeInventory, GetShoppingList).Show();
        }

        public void GetShoppingList(string name, ICollection<Recipe> recipes)
        {
            ShoppingList shoppingList = _queryRepository.CreateShoppingList(name, recipes);
            _shoppingLists.Add(shoppingList);
        }

        public void LaunchShowShoppingListForm(ShoppingList currentShoppingList)
        {
            new uiShowShoppingList(currentShoppingList).Show();
        }

        public void GoShopping(ShoppingList list)
        {
            foreach(KeyValuePair<Ingredient, int> ingred in list.ShoppingListItems)
            {
                _queryRepository.UpdateIngredientQuantity(ingred.Value, ingred.Key);
            }
        }

    }
}
