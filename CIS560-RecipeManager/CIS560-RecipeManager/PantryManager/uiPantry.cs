using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS560_RecipeManager.PantryManager;

namespace CIS560_RecipeManager
{
    public partial class uiPantry : Form
    {
        private Action _launchAddIngredientDelegate;
        private PantryViewModel _viewModel;

        public uiPantry(Action launchAddIngredientDelegate, PantryViewModel viewModel)
        {
            _viewModel = viewModel;
            _launchAddIngredientDelegate = launchAddIngredientDelegate;
            InitializeComponent();
            pantryItemBindingSource.DataSource = _viewModel.IngredientList;
            uxPantryItemsDataGridView.DataSource = pantryItemBindingSource;
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            _launchAddIngredientDelegate();
            //todo: update Grid View
        }

        private void updateIngredientButton_Click(object sender, EventArgs e)
        {
            //launch updateIngredient form
            using (uiUpdateIngredient f2 = new uiUpdateIngredient())
            {
                f2.ShowDialog(this);
            }
        }
    }
}
