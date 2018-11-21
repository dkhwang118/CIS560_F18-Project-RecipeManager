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
        private Action<Recipe> _deleteRecipeDelegate;
        private Action<Recipe> _cookRecipeDelegate;
        private RecipeInventory _recipeInventory;
        private DataGridViewGrouper _grouper;

        public uiRecipe(
            Action launchAddRecipeForm,
            Action<Recipe> launchEditRecipeForm,
            Action<Recipe> deleteRecipeDelegate,
            Action<Recipe> cookRecipeDelegate,
            RecipeInventory recipeInventory)
        {
            _launchAddRecipeForm = launchAddRecipeForm;
            _launchEditRecipeForm = launchEditRecipeForm;
            _deleteRecipeDelegate = deleteRecipeDelegate;
            _cookRecipeDelegate = cookRecipeDelegate;
            _recipeInventory = recipeInventory;
            InitializeComponent();
            RecipeBindingSource.DataSource = _recipeInventory.RecipeCollection;
            RecipeDataGridView.DataSource = RecipeBindingSource;
            SetGrouper();
        }

        private void SetGrouper()
        {
            _grouper = new DataGridViewGrouper(RecipeDataGridView);
            _grouper.SetGroupOn(RecipeDataGridView.Columns[1]);
            _grouper.Options.StartCollapsed = true;
            _grouper.Options.SelectRowsOnDoubleClick = false;
        }

        private void uxButton_AddRecipe_Click(object sender, EventArgs e)
        {
            _launchAddRecipeForm();
        }

        private void RecipeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (RecipeDataGridView.Rows[e.RowIndex].DataBoundItem is Recipe))
            {
                var row = RecipeDataGridView.Rows[e.RowIndex];
                Recipe recipe = (Recipe)row.DataBoundItem;
                _launchEditRecipeForm(recipe);
                _grouper.ResetGrouping();
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
            _deleteRecipeDelegate(recipe);
        }

        private void cookRecipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var row = RecipeDataGridView.SelectedRows[0];
            Recipe recipe = (Recipe)row.DataBoundItem;
            _cookRecipeDelegate(recipe);
            MessageBox.Show("Successfully cooked " + recipe.Name + " recipe!");
        }
    }
}
