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
    public partial class uiShowShoppingList : Form
    {
        private ShoppingList _currentShoppingList;
        public uiShowShoppingList(ShoppingList currentShoppingList)
        {
            _currentShoppingList = currentShoppingList;
            InitializeComponent();
        }

        private void uiShowShoppingList_Load(object sender, EventArgs e)
        {
            foreach (KeyValuePair<Ingredient, int> i in _currentShoppingList.ShoppingListItems)
            {
                DataGridViewRow row = (DataGridViewRow)uxDataGridView_ShowShoppingList.Rows[0].Clone();
                row.Cells[0].Value = i.Key.Name;
                row.Cells[1].Value = i.Value;
                uxDataGridView_ShowShoppingList.Rows.Add(row);
            }
        }
    }
}
