using CIS560_RecipeManager.RecipeManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560_RecipeManager
{
    public partial class uiRecipe : Form
    {
        private Action _launchAddRecipeForm;
        private RecipeInventory _recipeInventory;

        public uiRecipe(Action launchAddRecipeForm, RecipeInventory recipeInventory)
        {
            _launchAddRecipeForm = launchAddRecipeForm;
            _recipeInventory = recipeInventory;
            InitializeComponent();
            RecipeBindingSource.DataSource = _recipeInventory.RecipeCollection;
            RecipeDataGridView.DataSource = RecipeBindingSource;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uxButton_AddRecipe_Click(object sender, EventArgs e)
        {
            _launchAddRecipeForm();
        }
    }
}
