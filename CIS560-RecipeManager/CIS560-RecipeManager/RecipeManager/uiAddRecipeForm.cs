using CIS560_RecipeManager.RecipeManager;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

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
            totalIngredientsBindingSource.DataSource = _viewModel.TotalIngredients;
            totalIngredientsDGV.DataSource = totalIngredientsBindingSource;
            recipeIngredientsBindingSource.DataSource = _viewModel.RecipeIngredients;
            recipeIngredientsDGV.DataSource = recipeIngredientsBindingSource;
            
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
                DataGridViewRow row = totalIngredientsDGV.Rows[e.RowIndex];
                Ingredient i = (Ingredient)row.DataBoundItem;
                if (!_viewModel.RecipeIngredients.Any(x => x.Id == i.Id))
                {
                    RecipeIngredient ri = new RecipeIngredient(i.Id, i.Name, i.Unit, 0);
                    _viewModel.RecipeIngredients.Add(ri);
                }
            }
        }
    }
}
