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

        private void uxButton_AddIngredient_Click(object sender, EventArgs e)
        {
            int pantryQuantity;
            int priceInCents;

            bool validPantry = int.TryParse(uxTextBox_PantryQuantity.Text, out pantryQuantity);
            bool validPrice = int.TryParse(uxTextBox_PriceInCents.Text, out priceInCents);
            
            if (validPantry && validPrice)
            {
                _createIngredientDelegate(
                    uxTextBox_IngredientName.Text,
                    uxTextBox_UnitMeasurement.Text,
                    pantryQuantity,
                    priceInCents
                );
                Close();
            }
            else if (!validPantry)
            {
                MessageBox.Show("Pantry Quantity must contain only a whole number.");
            }
            else
            {
                MessageBox.Show("Price in cents must contain only a whole number.");
            }
        }
    }
}
