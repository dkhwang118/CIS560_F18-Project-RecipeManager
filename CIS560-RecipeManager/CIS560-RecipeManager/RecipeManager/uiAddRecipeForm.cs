using CIS560_RecipeManager.RecipeManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using static CIS560_RecipeManager.RecipeManager.Recipe;
using static CIS560_RecipeManager.RecipeManager.RecipeController;

namespace CIS560_RecipeManager
{
    public partial class uiAddRecipeForm : Form
    {
        private Action<string, string, IDictionary<Ingredient, int>> _addRecipeDelegate;
        private Action _launchAddIngredientForm;

        public uiAddRecipeForm(
            Action<string, string, IDictionary<Ingredient,int>> addRecipeDelegate,
            Action launchAddIngredientForm)
        {
            _addRecipeDelegate = addRecipeDelegate;
            _launchAddIngredientForm = launchAddIngredientForm;
            InitializeComponent();
        }

        public void uxButton_AddRecipe_Click(object sender, EventArgs e)
        {
            IDictionary<Ingredient, int> ingredients = new Dictionary<Ingredient, int>();
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
                ingredientsInRecipeDGV.Rows.Add(
                    row.Cells[0].Value.ToString(),
                    row.Cells[1].Value.ToString(),
                    "0"
                    );
            }
        }
    }
}
