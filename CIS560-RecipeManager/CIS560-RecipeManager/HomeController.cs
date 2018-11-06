using CIS560_RecipeManager.PantryManager;
using CIS560_RecipeManager.RecipeManager;
using CIS560_RecipeManager.ShoppingListManager;
using System.Windows.Forms;

namespace CIS560_RecipeManager
{
    public class HomeController
    {
        public delegate void LaunchRecipeManager();
        public delegate void LaunchPantryManager();
        public delegate void LaunchShoppingListManager();

        private RecipeController recipeController = new RecipeController();
        private PantryController pantryController = new PantryController();
        private ShoppingListController shoppingListController = new ShoppingListController();


        public void LaunchHomeForm()
        {
            LaunchRecipeManager launchRecipeManager = recipeController.LaunchRecipeForm;
            LaunchPantryManager launchPantryManager = pantryController.LaunchPantryForm;
            LaunchShoppingListManager launchShoppingListManager = shoppingListController.LaunchShoppingListForm;

            Application.Run(new uiHome(
                launchRecipeManager,
                launchPantryManager,
                launchShoppingListManager));
        }
    }
}
