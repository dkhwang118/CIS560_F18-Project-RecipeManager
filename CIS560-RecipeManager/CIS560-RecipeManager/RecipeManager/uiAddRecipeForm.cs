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
using static CIS560_RecipeManager.RecipeManager.RecipeController;

namespace CIS560_RecipeManager
{
    public partial class uiAddRecipeForm : Form
    {
        private AddRecipeDelegate _addRecipeDelegate;

        public uiAddRecipeForm(AddRecipeDelegate addRecipeDelegate)
        {
            _addRecipeDelegate = addRecipeDelegate;
            InitializeComponent();
        }

        public void uxButton_AddRecipe_Click(object sender, EventArgs e)
        {
            //Still need to implement UI functionality to allow the user to add ingredients to a Recipe
            IDictionary<Ingredient, int> ingredients = new Dictionary<Ingredient, int>();
            _addRecipeDelegate(uxTextBox_RecipeName.Text, uxTextBox_RecipeDescription.Text, ingredients);
            MessageBox.Show("Recipe " + uxTextBox_RecipeName.Text + " was created!");
            
        }
    }
}
