using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS560_RecipeManager.RecipeManager;

namespace CIS560_RecipeManager.ShoppingListManager
{
    public partial class uiShoppingList : Form
    {
        private Action<string, ICollection<Recipe>> _launchAddShoppingListDelegate;
        private ShoppingListInventory _shoppingListInventory;
        private Action<ShoppingList> _launchShowShoppingListDelegate;
        private Action<ShoppingList> _addShoppingListToPantry;

        public uiShoppingList(
            Action<string, ICollection<Recipe>> launchAddShoppingListDelegate, 
            Action<ShoppingList> launchShowShoppingListDelegate,
            Action<ShoppingList> addShoppingListToPantry,
            ShoppingListInventory shoppingListInventory)
        {
            _addShoppingListToPantry = addShoppingListToPantry;
            _shoppingListInventory = shoppingListInventory;
            _launchShowShoppingListDelegate = launchShowShoppingListDelegate;
            _launchAddShoppingListDelegate = launchAddShoppingListDelegate;
            InitializeComponent();
            shoppingListBindingSource.DataSource = _shoppingListInventory.ShoppingLists;
        }

        private void uxButton_AddShoppingList_Click(object sender, EventArgs e)
        {
            string name = "";
            ICollection<Recipe> recipes = new List<Recipe>();
            _launchAddShoppingListDelegate(name, recipes);
            uxDataGridView_ShoppingList.Update();
        }

        private void uxButton_ShowShoppingList_Click(object sender, EventArgs e)
        {
            ShoppingList current = new ShoppingList(0, "name");
            foreach(DataGridViewRow row in uxDataGridView_ShoppingList.SelectedRows)
            {
                current = (ShoppingList)row.DataBoundItem;
            }
            new uiShowShoppingList(current).Show();
        }

        private void uxButton_ShopFromList_Click(object sender, EventArgs e)
        {
            ShoppingList current = new ShoppingList(0, "name");
            foreach (DataGridViewRow row in uxDataGridView_ShoppingList.SelectedRows)
            {
                current = (ShoppingList)row.DataBoundItem;
            }
            _addShoppingListToPantry(current);
            MessageBox.Show("Added " + current.Name + " items back to pantry!");
        }
    }
}
