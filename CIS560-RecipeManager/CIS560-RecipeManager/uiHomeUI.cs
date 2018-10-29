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
    public partial class uiHomeUI : Form
    {
        public uiHomeUI()
        {
            InitializeComponent();
            uxConnectionString.Text = Properties.Settings.Default.RecipeDatabaseConnectionString;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
