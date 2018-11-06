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
    public partial class uiHome : Form
    {
        public uiHome()
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
            (new uiAddNewRecipe_BASIC()).ShowDialog();
            this.recipesTableAdapter.Fill(this.recipeDatabaseDataSet_DEMO.Recipes);
        }

        private void uiHomeUI_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recipeDatabaseDataSet_DEMO.Recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter.Fill(this.recipeDatabaseDataSet_DEMO.Recipes);
            (new uiSplashWelcome()).ShowDialog();

        }
    }
}
