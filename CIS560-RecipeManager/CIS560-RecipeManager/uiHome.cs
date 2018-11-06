using System.Windows.Forms;
using static CIS560_RecipeManager.HomeController;

namespace CIS560_RecipeManager
{
    public partial class uiHome : Form
    {
        private LaunchRecipeManager launchRecipeManager;
        private LaunchPantryManager launchPantryManager;
        private LaunchShoppingListManager launchShoppingListManager;

        public uiHome(
            LaunchRecipeManager rm,
            LaunchPantryManager pm,
            LaunchShoppingListManager sl)
        {
            launchRecipeManager = rm;
            launchPantryManager = pm;
            launchShoppingListManager = sl;
            InitializeComponent();
        }

        private void manageRecipesButton_Click(object sender, System.EventArgs e)
        {
            launchRecipeManager();
        }

        private void managePantryButton_Click(object sender, System.EventArgs e)
        {
            launchPantryManager();
        }

        private void manageShoppingListButton_Click(object sender, System.EventArgs e)
        {
            launchShoppingListManager();
        }
    }
}
