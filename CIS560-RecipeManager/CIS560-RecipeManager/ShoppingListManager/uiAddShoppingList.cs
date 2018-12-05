using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CIS560_RecipeManager.RecipeManager;

namespace CIS560_RecipeManager.ShoppingListManager
{
    public partial class uiAddShoppingList : Form
    {
        private Action<string, ICollection<Recipe>> _getShoppingListDelegate;
        private RecipeInventory _recipeInventory;
        private ShoppingListInventory _shoppingListInventory;
        public uiAddShoppingList(Action<string, ICollection<Recipe>> getShoppingList, 
            RecipeInventory recipeInventory, 
            ShoppingListInventory shoppingListInventory)
        {
            _shoppingListInventory = shoppingListInventory;
            _recipeInventory = recipeInventory;
            InitializeComponent();
            _getShoppingListDelegate = getShoppingList;
        }

        private void uiAddShoppingList_Load(object sender, EventArgs e)
        {
            this.recipesTableAdapter.Fill(this.recipeDatabaseDataSet.Recipes);

        }

        private void uxButton_CreateShoppingListFromRecipe_Click(object sender, EventArgs e)
        {
            ICollection<Recipe> recipes = new List<Recipe>();
            foreach (DataGridViewRow row in uxDataGridView_RecipesForShoppingList.SelectedRows)
            {
                if (row.Index > 0 && row.Index < _recipeInventory.VisibleRecipes.Count)
                {
                    for (int i = 0; i < _recipeInventory.VisibleRecipes.Count; i++)
                    {
                        if (_recipeInventory.VisibleRecipes[i].Id == Convert.ToInt32(row.Cells["ID"].Value.ToString()))
                        {
                            recipes.Add(_recipeInventory.VisibleRecipes[i]);
                        }
                    }
                }
            }
            _shoppingListInventory.CreateShoppingList(uxTextBox_ShoppingListName.Text, recipes);
            Close();
        }
    }
}
