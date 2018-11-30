using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS560_RecipeManager.RecipeManager
{
    public partial class RateRecipeForm : Form
    {
        public int Rating { get; set; }
        public RateRecipeForm()
        {
            InitializeComponent();
        }

        private void rateRecipeButton_Click(object sender, EventArgs e)
        {
            Rating = Convert.ToInt32(uxRatingSelector.Value);
            DialogResult = DialogResult.OK;
        }
    }
}
