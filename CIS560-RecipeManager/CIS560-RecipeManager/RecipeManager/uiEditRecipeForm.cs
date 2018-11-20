using CIS560_RecipeManager.RecipeManager;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace CIS560_RecipeManager
{
    public partial class uiEditRecipeForm : Form
    {
        private Action<string, string, IDictionary<Ingredient, int>> _addRecipeDelegate;
        private Action _launchAddIngredientForm;
        private EditRecipeViewModel _viewModel;

        public uiEditRecipeForm(
            Action<string, string, IDictionary<Ingredient,int>> addRecipeDelegate,
            Action launchAddIngredientForm,
            EditRecipeViewModel viewModel)
        {
            _addRecipeDelegate = addRecipeDelegate;
            _launchAddIngredientForm = launchAddIngredientForm;
            _viewModel = viewModel;
            InitializeComponent();
            totalIngredientsBindingSource.DataSource = _viewModel.TotalIngredients;
            totalIngredientsDGV.DataSource = totalIngredientsBindingSource;
            recipeIngredientsBindingSource.DataSource = _viewModel.RecipeIngredients;
            recipeIngredientsDGV.DataSource = recipeIngredientsBindingSource;
        }

        private void PopulateIngredientQuantities()
        {
            for (int i = 0; i < recipeIngredientsDGV.RowCount; i++)
            {
                recipeIngredientsDGV.Rows[i].Cells[2].Value = _viewModel.IngredientQuantities[i];
            }
        }

        public void uxButton_AddRecipe_Click(object sender, EventArgs e)
        {
            IDictionary<Ingredient, int> ingredients = new Dictionary<Ingredient, int>();

            for (int i = 0; i < _viewModel.RecipeIngredients.Count; i++)
            {
                int quantity = Convert.ToInt32(recipeIngredientsDGV.Rows[i].Cells[2].Value);
                ingredients.Add(_viewModel.RecipeIngredients.ElementAt(i), quantity);
            }

            _addRecipeDelegate(uxTextBox_RecipeName.Text, uxTextBox_RecipeDescription.Text, ingredients);
            MessageBox.Show("Recipe " + uxTextBox_RecipeName.Text + " was created!");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            _launchAddIngredientForm();
        }

        private void totalIngredientsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = totalIngredientsDGV.Rows[e.RowIndex];
                Ingredient i = (Ingredient)row.DataBoundItem;
                if (!_viewModel.RecipeIngredients.Contains(i))
                {
                    _viewModel.RecipeIngredients.Add(i);
                    //setting the default value of the recipe quantity column to 1
                    recipeIngredientsDGV.Rows[recipeIngredientsDGV.RowCount - 1].Cells[2].Value = "1";
                }
            }
        }

        private void recipeIngredientsDGV_BindingContextChanged(object sender, EventArgs e)
        {
            PopulateIngredientQuantities();
        }
    }
}
