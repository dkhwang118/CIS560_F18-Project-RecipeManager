using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560_RecipeManager.StatsFormManager
{
    public partial class uiRecipeRatingsForm : Form
    {
        GetStatsManager _statsManager;
        public uiRecipeRatingsForm(GetStatsManager gsm)
        {
            _statsManager = gsm;
            InitializeComponent();
        }

        private void uxButton_GetTopRatedRecipesPerCategory_Click(object sender, EventArgs e)
        {
            RecipeRatingsBindingSource.DataSource = _statsManager.GetTopRatedRecipesWithTies(Convert.ToInt32(uxTextBox_AmtPerCategoryToReturn.Text));
            uxDGV_RecipeRatingOutput.DataSource = RecipeRatingsBindingSource;
            uxDGV_RecipeRatingOutput.Columns[0].Visible = false; // recipeId
            uxDGV_RecipeRatingOutput.Columns[2].Visible = false; // recipeDescription
            uxDGV_RecipeRatingOutput.Columns[4].Visible = false; // MeasuredIngredientss list
            uxDGV_RecipeRatingOutput.Columns[5].Visible = false; // priceInCents
            uxDGV_RecipeRatingOutput.Columns[6].Visible = false; // formatted price
            uxDGV_RecipeRatingOutput.Columns[7].Visible = false; // formatted price


            uxDGV_RecipeRatingOutput.Columns[1].HeaderText = "Recipe Name";
            uxDGV_RecipeRatingOutput.Columns[3].HeaderText = "Recipe Category";
            uxDGV_RecipeRatingOutput.Columns[8].HeaderText = "Recipe Rating";
            uxDGV_RecipeRatingOutput.Columns[3].DisplayIndex = 0;
        }

        private void uxButton_GetAvgRecpieRatingPerCat_Click(object sender, EventArgs e)
        {
            RecipeRatingsBindingSource.DataSource = _statsManager.GetAvgRatingPerCategory();
            uxDGV_RecipeRatingOutput.DataSource = RecipeRatingsBindingSource;
            uxDGV_RecipeRatingOutput.Columns[0].HeaderText = "Recipe Category";
            uxDGV_RecipeRatingOutput.Columns[1].HeaderText = "Average Recipe Rating";
        }
    }
}
