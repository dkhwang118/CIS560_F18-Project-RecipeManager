using CIS560_RecipeManager.PantryManager;
using CIS560_RecipeManager.RecipeManager;
using CIS560_RecipeManager.Repository;
using CIS560_RecipeManager.ShoppingListManager;
using System.Windows.Forms;

namespace CIS560_RecipeManager
{
    public class HomeController
    {
        public delegate void LaunchRecipeManager();
        public delegate void LaunchPantryManager();
        public delegate void LaunchShoppingListManager();

        private RecipeController recipeController;
        private PantryController pantryController;
        private ShoppingListController shoppingListController;

        private LaunchRecipeManager launchRecipeManager;
        private LaunchPantryManager launchPantryManager;
        private LaunchShoppingListManager launchShoppingListManager;

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
