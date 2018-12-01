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
            int count = 0;
            foreach(KeyValuePair<Ingredient, int> i in _currentShoppingList.ShoppingListItems)
            {
                count++;
                uxDataGridView_ShowShoppingList.Rows[count].Cells[0].Value = i.Key;
                uxDataGridView_ShowShoppingList.Rows[count].Cells[1].Value = i.Value;
            }
        }
    }
}
