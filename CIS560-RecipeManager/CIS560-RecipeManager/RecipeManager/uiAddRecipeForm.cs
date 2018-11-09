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
    public partial class uiAddRecipeForm : Form
    {
        public uiAddRecipeForm()
        {
            InitializeComponent();
        }

        public void uxButton_AddRecipe_Click(object sender, EventArgs e)
        {
            RecipeRepository rrTemp = new RecipeRepository();
            Recipe temp = rrTemp.CreateRecipe(uxTextBox_RecipeName.Text, uxTextBox_RecipeDescription.Text);
            MessageBox.Show("Recipe " + temp.Name + " was created!");
            
        }
    }
}
