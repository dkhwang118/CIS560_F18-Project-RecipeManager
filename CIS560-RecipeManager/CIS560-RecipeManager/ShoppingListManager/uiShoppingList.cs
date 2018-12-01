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
        private ICollection<ShoppingList> _shoppingLists = new List<ShoppingList>();
        private Action<ShoppingList> _launchShowShoppingListDelegate;
        public uiShoppingList(Action<string, ICollection<Recipe>> launchAddShoppingListDelegate, Action<ShoppingList> launchShowShoppingListDelegate, ShoppingListInventory shoppingListInventory)
        {
            _shoppingListInventory = shoppingListInventory;
            _launchShowShoppingListDelegate = launchShowShoppingListDelegate;
            _launchAddShoppingListDelegate = launchAddShoppingListDelegate;
            InitializeComponent();
        }

        private void uiShoppingList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recipeDatabaseDataSet.ShoppingList' table. You can move, or remove it, as needed.
            this.shoppingListTableAdapter.Fill(this.recipeDatabaseDataSet.ShoppingList);
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
            _shoppingListInventory.UpdateIngredients(current);
        }
    }
}
