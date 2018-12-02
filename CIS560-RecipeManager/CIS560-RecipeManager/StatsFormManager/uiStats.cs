using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560_RecipeManager.StatsFormManager
{
    public partial class uiStats : Form
    {
        private Action _launchRecipesNotCookedRecentForm;
        private Action _launchRecipeRatingsForm;
        private GetStatsManager _statsManager;

        public uiStats(Action launchRecipesNotCookedRecentForm,
                        Action launchRecipeRatingsForm)
        {
            _launchRecipesNotCookedRecentForm = launchRecipesNotCookedRecentForm;
            _launchRecipeRatingsForm = launchRecipeRatingsForm;

            InitializeComponent();
        }

        private void uxButton_RecipesNotCookedRecent_Click(object sender, EventArgs e)
        {
            _launchRecipesNotCookedRecentForm();
        }

        private void uxButton_RecipeRatings_Click(object sender, EventArgs e)
        {
            _launchRecipeRatingsForm();
        }
    }
}
