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
        public uiAddShoppingList(RecipeInventory recipeInventory, Action<string, ICollection<Recipe>> getShoppingList)
        {
            _recipeInventory = recipeInventory;
            InitializeComponent();
            recipesBindingSource.DataSource = _recipeInventory.VisibleRecipes;
            uxDataGridView_RecipesForShoppingList.DataSource = recipesBindingSource;
            _getShoppingListDelegate = getShoppingList;
        }

        private void uiAddShoppingList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recipeDatabaseDataSet.Recipes' table. You can move, or remove it, as needed.
            this.recipesTableAdapter.Fill(this.recipeDatabaseDataSet.Recipes);


        }

        private void uxButton_CreateShoppingListFromRecipe_Click(object sender, EventArgs e)
        {
            ICollection<Recipe> recipes = null;
            foreach (DataGridViewRow row in uxDataGridView_RecipesForShoppingList.SelectedRows)
            {
                recipes.Add((Recipe)row.DataBoundItem);
            }
            _getShoppingListDelegate(uxTextBox_ShoppingListName.Text, recipes);
            Close();
        }
    }
}
