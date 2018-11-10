using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560_RecipeManager.RecipeManager
{
    public partial class uiRecipeDetailForm : Form
    {
        private Recipe _recipe;

        public uiRecipeDetailForm(Recipe recipe)
        {
            _recipe = recipe;
            InitializeComponent();
            PopulateRecipeDetails();
        }

        public void PopulateRecipeDetails()
        {
            RecipeNameLabel.Text = _recipe.Name;
            RecipeDirectionTextBox.Text = _recipe.Description;
            RecipeDetailDGV.DataSource = _recipe.MeasuredIngredients;
        }
    }
}
