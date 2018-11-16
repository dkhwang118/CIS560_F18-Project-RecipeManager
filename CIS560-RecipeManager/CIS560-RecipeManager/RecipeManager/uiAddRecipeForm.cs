using CIS560_RecipeManager.RecipeManager;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CIS560_RecipeManager
{
    public partial class uiAddRecipeForm : Form
    {
        private Action<string, string, IDictionary<Ingredient, int>> _addRecipeDelegate;
        private Action _launchAddIngredientForm;
        private AddRecipeViewModel _viewModel;

        public uiAddRecipeForm(
            Action<string, string, IDictionary<Ingredient,int>> addRecipeDelegate,
            Action launchAddIngredientForm,
            AddRecipeViewModel viewModel)
        {
            _addRecipeDelegate = addRecipeDelegate;
            _launchAddIngredientForm = launchAddIngredientForm;
            _viewModel = viewModel;
            InitializeComponent();
        }

        public void uxButton_AddRecipe_Click(object sender, EventArgs e)
        {
            IDictionary<Ingredient, int> ingredients = new Dictionary<Ingredient, int>();

            foreach (RecipeIngredient ing in _viewModel.RecipeIngredients)
            {
                ingredients.Add(
                    new Ingredient(ing.Id, ing.Name, ing.Unit),
                    ing.Quantity
                    );
            }

            _addRecipeDelegate(uxTextBox_RecipeName.Text, uxTextBox_RecipeDescription.Text, ingredients);
            MessageBox.Show("Recipe " + uxTextBox_RecipeName.Text + " was created!");
            
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            _launchAddIngredientForm();
        }

        private void totalIngredientsDGV_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.totalIngredientsDGV.Rows[e.RowIndex];

                RecipeIngredient ing = new RecipeIngredient(
                    Convert.ToInt32(row.Cells[0].Value),
                    row.Cells[1].Value.ToString(),
                    row.Cells[2].Value.ToString(),
                    0
                    );
                _viewModel.RecipeIngredients.Add(ing);
            }
        }
    }
}
