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
        private Action<ShoppingList> _showShoppingListDelegate;
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
        //list of shopping lists in controller should use query to get all shopping lists, then can search through list to find current one selected to display all ingredients and quantities.
        //how to display in data gride view though?
    }
}
