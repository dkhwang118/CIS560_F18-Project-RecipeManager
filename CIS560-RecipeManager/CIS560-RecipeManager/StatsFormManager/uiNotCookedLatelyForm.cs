using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS560_RecipeManager.RecipeManager;

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
            try
            {
                RecentlyCookedBindingSource.DataSource = _statsManager.GetLeastRecentlyCookedRecipes();
                uxDGV_RecipesCookedStatsOutput.DataSource = RecentlyCookedBindingSource;
                uxDGV_RecipesCookedStatsOutput.Columns[0].MinimumWidth = 200;
                uxDGV_RecipesCookedStatsOutput.Columns[1].MinimumWidth = 200;
                uxDGV_RecipesCookedStatsOutput.Columns[0].HeaderText = "Recipe Name";
                uxDGV_RecipesCookedStatsOutput.Columns[1].HeaderText = "Date Last Cooked";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void uxButton_ShowUncookedRecipes_Click(object sender, EventArgs e)
        {
            RecentlyCookedBindingSource.DataSource = _statsManager.GetRecipesNotCooked();
            uxDGV_RecipesCookedStatsOutput.DataSource = RecentlyCookedBindingSource;
            for (int i = 0; i < uxDGV_RecipesCookedStatsOutput.ColumnCount; i++)
            {
                uxDGV_RecipesCookedStatsOutput.Columns[i].Visible = false;
            }
            uxDGV_RecipesCookedStatsOutput.Columns[1].MinimumWidth = 800;
            uxDGV_RecipesCookedStatsOutput.Columns[1].Visible = true;

        }

        private void uxDGV_RecipesCookedStatsOutput_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if (e.RowIndex >= 0 && (uxDGV_RecipesCookedStatsOutput.Rows[e.RowIndex].DataBoundItem is Recipe))
            {
                var row = RecipeDataGridView.Rows[e.RowIndex];
                Recipe recipe = (Recipe)row.DataBoundItem;
                new uiEditRecipeForm(recipe);
            }
            */
            // Do nothing for now
        }
    }
}
