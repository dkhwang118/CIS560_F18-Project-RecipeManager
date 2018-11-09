using CIS560_RecipeManager.PantryManager;
using CIS560_RecipeManager.RecipeManager;
using CIS560_RecipeManager.Repository;
using CIS560_RecipeManager.ShoppingListManager;

using System;
using System.Windows.Forms;

namespace CIS560_RecipeManager
{
    public class HomeController
    {
        private RecipeController _recipeController;
        private PantryController _pantryController;
        private ShoppingListController _shoppingListController;

        // Action is the type of methods with no inputs and no outputs.
        private Action _launchRecipeManager;
        private Action _launchPantryManager;
        private Action _launchShoppingListManager;

        private RecipeInventory _recipeInventory;
        private Pantry _pantry;

        private IQuery _queryStub;

        public HomeController()
        {
            _queryStub = new QueryStub();
            _recipeInventory = new RecipeInventory();

            _recipeController = new RecipeController(_queryStub, _recipeInventory, _pantry);
            _pantryController = new PantryController(_queryStub, _pantry);
            _shoppingListController = new ShoppingListController(_queryStub, _pantry, _recipeInventory);

            _launchRecipeManager = _recipeController.LaunchRecipeForm;
            _launchPantryManager = _pantryController.LaunchPantryForm;
            _launchShoppingListManager = _shoppingListController.LaunchShoppingListForm;
        }


        public void LaunchHomeForm()
        {
            Application.Run(new uiHome(
                _launchRecipeManager,
                _launchPantryManager,
                _launchShoppingListManager));
        }
    }
}
