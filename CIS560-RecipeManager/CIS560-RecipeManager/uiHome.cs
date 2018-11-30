using System;
using System.Windows.Forms;

using static CIS560_RecipeManager.HomeController;

namespace CIS560_RecipeManager
{
    public partial class uiHome : Form
    {
        private Action launchRecipeManager;
        private Action launchPantryManager;
        private Action launchShoppingListManager;
        private Action launchStatsFormManager;

        public uiHome(
            Action rm,
            Action pm,
            Action sl,
            Action st)
        {
            launchRecipeManager = rm;
            launchPantryManager = pm;
            launchShoppingListManager = sl;
            launchStatsFormManager = st;
            InitializeComponent();
        }

        private void manageRecipesButton_Click(object sender, EventArgs e)
        {
            launchRecipeManager();
        }

        private void managePantryButton_Click(object sender, EventArgs e)
        {
            launchPantryManager();
        }

        private void manageShoppingListButton_Click(object sender, EventArgs e)
        {
            launchShoppingListManager();
        }

        private void uxButton_ExtraFeatures_Click(object sender, EventArgs e)
        {
            launchStatsFormManager();
        }
    }
}
