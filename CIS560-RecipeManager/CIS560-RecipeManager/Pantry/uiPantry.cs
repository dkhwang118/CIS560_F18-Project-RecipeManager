using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560_RecipeManager
{
    public partial class uiPantry : Form
    {
        public uiPantry()
        {
            InitializeComponent();
        }

        private void uiPantryItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recipeDatabaseDataSet.PantryItem' table. You can move, or remove it, as needed.
            this.pantryItemTableAdapter.Fill(this.recipeDatabaseDataSet.PantryItem);

        }
    }
}
