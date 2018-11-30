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
        private Action<Ingredient,int> _updateIngredientQuantity;
        private PantryViewModel _viewModel;

        public uiPantry(
            Action launchAddIngredientDelegate,
            Action<Ingredient, int> updateIngredientQuantity,
            PantryViewModel viewModel)
        {
            _viewModel = viewModel;
            _launchAddIngredientDelegate = launchAddIngredientDelegate;
            _updateIngredientQuantity = updateIngredientQuantity;
            InitializeComponent();
            pantryItemBindingSource.DataSource = _viewModel.IngredientList;
            uxPantryItemsDataGridView.DataSource = pantryItemBindingSource;
        }

        private void PopulateIngredientQuantities()
        {
            for (int i = 0; i < uxPantryItemsDataGridView.RowCount; i++)
            {
                uxPantryItemsDataGridView.Rows[i].Cells[3].Value = _viewModel.IngredientQuantities[i];
            }
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            _launchAddIngredientDelegate();
            //todo: update Grid View
        }

        private void uxPantryItemsDataGridView_BindingContextChanged(object sender, EventArgs e)
        {
            PopulateIngredientQuantities();
        }

        private void uxPantryItemsDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = uxPantryItemsDataGridView.Rows[e.RowIndex];
            var ing = (Ingredient)row.DataBoundItem;
            var quantity = Convert.ToInt32(row.Cells[3].Value.ToString());
            _updateIngredientQuantity(ing, quantity);
        }
    }
}
