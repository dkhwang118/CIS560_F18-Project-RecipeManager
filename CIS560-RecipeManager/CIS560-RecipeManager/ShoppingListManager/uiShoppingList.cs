using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560_RecipeManager.ShoppingListManager
{
    public partial class uiShoppingList : Form
    {
        private Action _launchAddShoppingListDelegate;
        private ICollection<ShoppingList> _shoppingLists = new List<ShoppingList>();
        private Action<ShoppingList> _launchShowShoppingListDelegate;
        private Action<ShoppingList> _launchGoShoppingDelegate;
        public uiShoppingList(Action launchAddShoppingListDelegate, Action<ShoppingList> launchShowShoppingListDelegate, ICollection<ShoppingList> shoppingLists, Action<ShoppingList> goShoppingDelegate)
        {
            _launchShowShoppingListDelegate = launchShowShoppingListDelegate;
            _launchAddShoppingListDelegate = launchAddShoppingListDelegate;
            _launchGoShoppingDelegate = goShoppingDelegate;
            _shoppingLists = shoppingLists;
            InitializeComponent();
        }

        private void uiShoppingList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recipeDatabaseDataSet.ShoppingList' table. You can move, or remove it, as needed.
            this.shoppingListTableAdapter.Fill(this.recipeDatabaseDataSet.ShoppingList);
            //foreach(ShoppingList list in _shoppingLists)
            //{
            //    for(int i = 0; i < _shoppingLists.Count; i ++)
            //    {
            //        uxDataGridView_ShoppingList.Rows[i].Cells[0].Value = list.Name;
            //    }
            //}
        }

        private void uxButton_AddShoppingList_Click(object sender, EventArgs e)
        {
            _launchAddShoppingListDelegate();
        }

        private void uxButton_ShowShoppingList_Click(object sender, EventArgs e)
        {
            ShoppingList current = new ShoppingList(0, "name");
            foreach(DataGridViewRow row in uxDataGridView_ShoppingList.SelectedRows)
            {
                current = (ShoppingList)row.DataBoundItem;
            }
            _launchShowShoppingListDelegate(current);
        }

        private void uxButton_ShopFromList_Click(object sender, EventArgs e)
        {
            ShoppingList current = new ShoppingList(0, "name");
            foreach (DataGridViewRow row in uxDataGridView_ShoppingList.SelectedRows)
            {
                current = (ShoppingList)row.DataBoundItem;
            }
            _launchGoShoppingDelegate(current);
        }
    }
}
