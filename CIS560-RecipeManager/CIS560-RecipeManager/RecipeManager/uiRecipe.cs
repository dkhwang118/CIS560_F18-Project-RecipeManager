using CIS560_RecipeManager.RecipeManager;
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
            var grouper = new Subro.Controls.DataGridViewGrouper(RecipeDataGridView);
            grouper.SetGroupOn(RecipeDataGridView.Columns[1]);
            grouper.Options.StartCollapsed = true;
        }

        private void uxButton_AddRecipe_Click(object sender, EventArgs e)
        {
            _launchAddRecipeForm();
        }

        private void RecipeDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = RecipeDataGridView.Rows[e.RowIndex];
                Recipe recipe = (Recipe)row.DataBoundItem;
                _launchEditRecipeForm(recipe);
            }
        }

        private void RecipeDataGridView_RowContextMenuStripNeeded(object sender, DataGridViewRowContextMenuStripNeededEventArgs e)
        {
            if (e.RowIndex < 0) return;
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
