using CIS560_RecipeManager.RecipeManager;
using Subro.Controls;
using System;
using System.Windows.Forms;

namespace CIS560_RecipeManager
{
    public partial class uiRecipe : Form
    {
        private Action _launchAddRecipeForm;
        private Action<Recipe> _launchEditRecipeForm;
        private RecipeInventory _recipeInventory;
        private Func<Recipe, bool> _cookRecipe;
        private DataGridViewGrouper _grouper;

        public uiRecipe(
            Action launchAddRecipeForm,
            Action<Recipe> launchEditRecipeForm,
            Func<Recipe, bool> cookRecipe,
            RecipeInventory recipeInventory)
        {
            _launchAddRecipeForm = launchAddRecipeForm;
            _launchEditRecipeForm = launchEditRecipeForm;
            _recipeInventory = recipeInventory;
            _cookRecipe = cookRecipe;
            InitializeComponent();
            RecipeBindingSource.DataSource = _recipeInventory.VisibleRecipes;
            RecipeDataGridView.DataSource = RecipeBindingSource;
            SetGrouper();
        }

        private void SetGrouper()
        {
            _grouper = new DataGridViewGrouper(RecipeDataGridView);
            _grouper.SetGroupOn(RecipeDataGridView.Columns[1]);
            _grouper.Options.StartCollapsed = true;
            _grouper.Options.SelectRowsOnDoubleClick = false;
            _grouper.Options.ShowGroupName = false;
        }

        private void uxButton_AddRecipe_Click(object sender, EventArgs e)
        {
            _launchAddRecipeForm();
            availableWithPantryCheckBox.Checked = false;
        }

        private void RecipeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (RecipeDataGridView.Rows[e.RowIndex].DataBoundItem is Recipe))
            {
                var row = RecipeDataGridView.Rows[e.RowIndex];
                Recipe recipe = (Recipe)row.DataBoundItem;
                _launchEditRecipeForm(recipe);
            }
        }

        private void RecipeDataGridView_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex < 0 || _grouper.IsGroupRow(e.RowIndex)) return;
            e.ContextMenuStrip = recipeContextMenuStrip;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = RecipeDataGridView.SelectedRows[0];
            Recipe recipe = (Recipe)row.DataBoundItem;
            _recipeInventory.DeleteRecipe(recipe);
        }

        private void cookRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = RecipeDataGridView.SelectedRows[0];
            Recipe recipe = (Recipe)row.DataBoundItem;
            if (_cookRecipe(recipe))
            {
                MessageBox.Show("Successfully cooked " + recipe.Name + " recipe!");
            }
            else
            {
                MessageBox.Show("Sorry! You don't have enough ingredients.");
            }
        }

        private void RecipeDataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            //Selecting the current row on a right mouse click.  This is so that
            //whenever the user right clicks on a row, the row will select and
            //can be used as the current row for the Context Menu
            if (e.Button == MouseButtons.Right)
            {
                var hti = RecipeDataGridView.HitTest(e.X, e.Y);
                RecipeDataGridView.ClearSelection();
                RecipeDataGridView.Rows[hti.RowIndex].Selected = true;
            }
        }

        private void rateRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new RateRecipeForm())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var row = RecipeDataGridView.SelectedRows[0];
                    Recipe recipe = (Recipe)row.DataBoundItem;
                    _recipeInventory.RateRecipe(recipe, form.Rating);
                    updateDataGridView(); // update DGV before MessageBox for "instant" update to DGV
                    MessageBox.Show("Successfully rated " + recipe.Name + " recipe!");
                }
            }
        }

        private void updateDataGridView()
        {
            if (budgetCheckBox.Checked)
            {
                int max = Convert.ToInt32(uxDollarSelector.Value);
                if (availableWithPantryCheckBox.Checked)
                {
                    _recipeInventory.OnlyDisplayAvailableAndBudgetRecipes(max);
                }
                else
                {
                    _recipeInventory.OnlyDisplayBudgetRecipes(max);
                }
            }
            else
            {
                if (availableWithPantryCheckBox.Checked)
                {
                    _recipeInventory.OnlyDisplayAvailableRecipes();
                }
                else
                {
                    _recipeInventory.DisplayAllRecipes();
                }
            }
        }


        private void availableWithPantryCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void budgetCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            updateDataGridView();
        }
    }
}
