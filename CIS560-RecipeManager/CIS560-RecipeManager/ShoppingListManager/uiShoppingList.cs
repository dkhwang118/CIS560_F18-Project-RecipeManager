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
        public uiShoppingList(Action launchAddShoppingListDelegate)
        {
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
            _launchAddShoppingListDelegate();
        }
    }
}
