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
    public partial class uiRecipeManager : Form
    {
        public uiRecipeManager()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*
         * Click Event for "Add Recipe" button
         */ 
        private void uxButton_AddRecipe_Click(object sender, EventArgs e)
        {
            (new uiAddRecipeForm()).ShowDialog();
            this.recipesTableAdapter.Fill(this.recipeDatabaseDataSet_DEMO.Recipes);
        }
    }
}
