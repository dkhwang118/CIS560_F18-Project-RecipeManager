using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CIS560_RecipeManager.ShoppingListManager.ShoppingListController;
using CIS560_RecipeManager.RecipeManager;

namespace CIS560_RecipeManager.ShoppingListManager
{
    public partial class uiAddShoppingList : Form
    {
        private Action<string, ICollection<Recipe>> _getShoppingListDelegate;
        private RecipeInventory _recipeInventory;
        private ICollection<Recipe> _recipes;
        public uiAddShoppingList(Action<string, ICollection<Recipe>> getShoppingList, RecipeInventory recipeInventory, ICollection<Recipe> recipes)
        {
            _recipes = recipes;
            _recipeInventory = recipeInventory;
            InitializeComponent();
            _getShoppingListDelegate = getShoppingList;
        }

        private void uiAddShoppingList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recipeDatabaseDataSet.Recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter.Fill(this.recipeDatabaseDataSet.Recipes);
            // TODO: This line of code loads data into the 'recipeDatabaseDataSet.Recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter.Fill(this.recipeDatabaseDataSet.Recipes);

        }

        private void uxButton_CreateShoppingListFromRecipe_Click(object sender, EventArgs e)
        {
            ICollection<Recipe> recipes = new List<Recipe>();
            foreach (DataGridViewRow row in uxDataGridView_RecipesForShoppingList.SelectedRows)
            {
                for(int i = 0; i < _recipeInventory.VisibleRecipes.Count; i++)
                {
                    if (_recipeInventory.VisibleRecipes[i].Id == Convert.ToInt32(row.Cells["ID"].Value.ToString()))
                    {
                        recipes.Add(_recipeInventory.VisibleRecipes[i]);
                    }
                } 
            }
            _getShoppingListDelegate(uxTextBox_ShoppingListName.Text, recipes);
            Close();
        }
    }
}
