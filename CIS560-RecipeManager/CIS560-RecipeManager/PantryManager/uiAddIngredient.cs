/*
 * uiAddIngredient.cs
 * Form to add a new ingredient to the database
 * 
 * Authors: Project Team 1 - CIS 560 KSU Fall 2018
 * edited by: David K. Hwang
 */

using System;
using System.Windows.Forms;
using static CIS560_RecipeManager.PantryManager.PantryController;

namespace CIS560_RecipeManager.Pantry
{
    public partial class uiAddIngredient : Form
    {
        private CreateIngredientDelegate _createIngredientDelegate;

        public uiAddIngredient(CreateIngredientDelegate createIngredient)
        {
            InitializeComponent();
            _createIngredientDelegate = createIngredient;
        }

        /// <summary>
        /// Click event for the "Add Ingredient" button on the Add Ingredient Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxButton_AddIngredient_Click(object sender, EventArgs e)
        {
            _createIngredientDelegate(
                uxTextBox_IngredientName.Text,
                uxTextBox_UnitMeasurement.Text,
                Convert.ToInt32(uxTextBox_PantryQuantity.Text)
                );
            Close();
        }
    }
}
