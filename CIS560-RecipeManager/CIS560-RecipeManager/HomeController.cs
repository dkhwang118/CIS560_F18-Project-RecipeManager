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
        private RecipeController recipeController;
        private PantryController pantryController;
        private ShoppingListController shoppingListController;

        // Action is the type of methods with no inputs and no outputs.
        private Action launchRecipeManager;
        private Action launchPantryManager;
        private Action launchShoppingListManager;

        private IQuery queryStub;

        public HomeController()
        {
            queryStub = new QueryStub();

            recipeController = new RecipeController(queryStub);
            pantryController = new PantryController(queryStub);
            shoppingListController = new ShoppingListController(queryStub);

            launchRecipeManager = recipeController.LaunchRecipeForm;
            launchPantryManager = pantryController.LaunchPantryForm;
            launchShoppingListManager = shoppingListController.LaunchShoppingListForm;
        }


        public void LaunchHomeForm()
        {
            Application.Run(new uiHome(
                launchRecipeManager,
                launchPantryManager,
                launchShoppingListManager));
        }
    }
}
