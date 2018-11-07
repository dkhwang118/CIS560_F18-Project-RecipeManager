using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560_RecipeManager.Pantry
{
    public partial class uiAddIngredient : Form
    {
        public Query query;


        public uiAddIngredient()
        {
            InitializeComponent();
        }

        private void uxButton_AddIngredient_Click(object sender, EventArgs e)
        {
            try
            {
                Ingredient temp = query.AddIngredient(uxTextBox_IngredientName.Text, uxTextBox_UnitMeasurement.Text, (Convert.ToInt32(uxTextBox_PantryQuantity.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not add ingredient to the database.\n" + "Error: " + ex.ToString());
            }
        }

        private void uiAddIngredient_Load(object sender, EventArgs e)
        {
            try
            {
                query = new Query();
                query.OpenConnection();
            }
            catch
            {
                MessageBox.Show("Could not establish connection to server. Please try again.");
                this.Close();
            }
        }
    }
}
