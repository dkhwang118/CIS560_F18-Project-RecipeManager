using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CIS560_RecipeManager.PantryManager.PantryController;

namespace CIS560_RecipeManager
{
    public partial class uiPantry : Form
    {
        private Action _launchAddIngredientDelegate;

        public uiPantry(Action launchAddIngredientDelegate)
        {
            _launchAddIngredientDelegate = launchAddIngredientDelegate;
            InitializeComponent();
        }

        private void uiPantryItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recipeDatabaseDataSet.PantryItem' table. You can move, or remove it, as needed.
            //this.pantryItemTableAdapter.Fill(this.recipeDatabaseDataSet.PantryItem);

        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            _launchAddIngredientDelegate();
            //todo: update Grid View
        }

        private void deleteIngredientButton_Click(object sender, EventArgs e)
        {

        }

        private void updateIngredientButton_Click(object sender, EventArgs e)
        {
           //launch updateIngredient form
        }
    }
}
