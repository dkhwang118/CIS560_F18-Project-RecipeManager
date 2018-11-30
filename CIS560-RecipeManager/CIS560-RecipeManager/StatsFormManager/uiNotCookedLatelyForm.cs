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
    public partial class uiNotCookedLatelyForm : Form
    {
        GetStatsManager _statsManager;


        public uiNotCookedLatelyForm(GetStatsManager gsm)
        {
            _statsManager = gsm;
            InitializeComponent();
        }

        private void uxButton_ShowLeastRecentCookedRecipes_Click(object sender, EventArgs e)
        {
            RecentlyCookedBindingSource.DataSource = _statsManager.GetLeastRecentlyCookedRecipes();
            uxDGV_RecipesCookedStatsOutput.DataSource = RecentlyCookedBindingSource;
        }

        private void uxButton_ShowUncookedRecipes_Click(object sender, EventArgs e)
        {
            RecentlyCookedBindingSource.DataSource = _statsManager.GetRecipesNotCooked();
            uxDGV_RecipesCookedStatsOutput.DataSource = RecentlyCookedBindingSource;
        }
    }
}
