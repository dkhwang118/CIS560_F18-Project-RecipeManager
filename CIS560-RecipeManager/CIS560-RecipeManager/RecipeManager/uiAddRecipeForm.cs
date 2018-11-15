using CIS560_RecipeManager.RecipeManager;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static CIS560_RecipeManager.RecipeManager.RecipeController;

namespace CIS560_RecipeManager
{
    public partial class uiAddRecipeForm : Form
    {
        private Action<string, string, IDictionary<Ingredient, int>> _addRecipeDelegate;

        public uiAddRecipeForm(Action<string, string, IDictionary<Ingredient,int>> addRecipeDelegate)
        {
            _addRecipeDelegate = addRecipeDelegate;
            InitializeComponent();
        }

        public void uxButton_AddRecipe_Click(object sender, EventArgs e)
        {
            IDictionary<Ingredient, int> ingredients = new Dictionary<Ingredient, int>();
            _addRecipeDelegate(uxTextBox_RecipeName.Text, uxTextBox_RecipeDescription.Text, ingredients);
            MessageBox.Show("Recipe " + uxTextBox_RecipeName.Text + " was created!");
            
        }
    }
}
