using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS560_RecipeManager.Pantry;

namespace CIS560_RecipeManager
{
    public partial class uiPantry : Form
    {
        public uiPantry()
        {
            InitializeComponent();
        }

        private void uiPantryItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recipeDatabase_IngredientTable.Ingredient' table. You can move, or remove it, as needed.
            this.ingredientTableAdapter.Fill(this.recipeDatabase_IngredientTable.Ingredient);

        }

        /// <summary>
        /// Click event for "Add Ingredient" uxButton_AddIngredient
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButton_AddIngredient_Click(object sender, EventArgs e)
        {
            new uiAddIngredient().Show();
        }

        /// <summary>
        /// Method to update the DataGridView table; Makes other forms able to call the update
        /// </summary>
        public void UpdateGridView()
        {
            this.ingredientTableAdapter.Fill(this.recipeDatabase_IngredientTable.Ingredient);
        }
    }
}
