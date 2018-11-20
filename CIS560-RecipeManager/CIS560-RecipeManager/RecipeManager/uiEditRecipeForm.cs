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
        private Action<Recipe> _updateRecipeDelegate;
        private Action _launchAddIngredientForm;
        private EditRecipeViewModel _viewModel;

        public uiEditRecipeForm(
            Action<string, string, IDictionary<Ingredient, int>> addRecipeDelegate,
            Action<Recipe> updateRecipeDelegate,
            Action launchAddIngredientForm,
            EditRecipeViewModel viewModel)
        {
            _addRecipeDelegate = addRecipeDelegate;
            _updateRecipeDelegate = updateRecipeDelegate;
            _launchAddIngredientForm = launchAddIngredientForm;
            _viewModel = viewModel;
            InitializeComponent();
            totalIngredientsBindingSource.DataSource = _viewModel.TotalIngredients;
            totalIngredientsDGV.DataSource = totalIngredientsBindingSource;
            recipeIngredientsBindingSource.DataSource = _viewModel.RecipeIngredients;
            recipeIngredientsDGV.DataSource = recipeIngredientsBindingSource;
            PopulateRecipeDetails();
        }

        private void PopulateRecipeDetails()
        {
            if (_viewModel.CurrentRecipe != null)
            {
                uxTextBox_RecipeName.Text = _viewModel.CurrentRecipe.Name;
                uxTextBox_RecipeDescription.Text = _viewModel.CurrentRecipe.Description;
            }
        }

        private void PopulateIngredientQuantities()
        {
            for (int i = 0; i < recipeIngredientsDGV.RowCount; i++)
            {
                recipeIngredientsDGV.Rows[i].Cells[2].Value = _viewModel.IngredientQuantities[i];
            }
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
                    _viewModel.IngredientQuantities.Add(1);
                    recipeIngredientsDGV.Rows[recipeIngredientsDGV.RowCount - 1].Cells[2].Value = "1";
                }
            }
        }

        private void recipeIngredientsDGV_BindingContextChanged(object sender, EventArgs e)
        {
            PopulateIngredientQuantities();
        }

        private void recipeIngredientsDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _viewModel.IngredientQuantities.RemoveAt(e.RowIndex);
                _viewModel.RecipeIngredients.RemoveAt(e.RowIndex);
            }
        }

        private void uxOKButton_Click(object sender, EventArgs e)
        {
            IDictionary<Ingredient, int> ingredients = new Dictionary<Ingredient, int>();

            for (int i = 0; i < _viewModel.RecipeIngredients.Count; i++)
            {
                int quantity = Convert.ToInt32(recipeIngredientsDGV.Rows[i].Cells[2].Value);
                ingredients.Add(_viewModel.RecipeIngredients.ElementAt(i), quantity);
            }

            if (_viewModel.CurrentRecipe == null)
            {
                _addRecipeDelegate(uxTextBox_RecipeName.Text, uxTextBox_RecipeDescription.Text, ingredients);
                MessageBox.Show("Recipe " + uxTextBox_RecipeName.Text + " was created!");
            }
            else
            {
                _viewModel.CurrentRecipe.Name = uxTextBox_RecipeName.Text;
                _viewModel.CurrentRecipe.Description = uxTextBox_RecipeDescription.Text;
                _viewModel.CurrentRecipe.PopulateMeasuredIngredients(ingredients);
                MessageBox.Show("Recipe " + uxTextBox_RecipeName.Text + " was updated!");

            }
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
