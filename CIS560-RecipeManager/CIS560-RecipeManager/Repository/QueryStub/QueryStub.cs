using System.Collections.Generic;

namespace CIS560_RecipeManager.Repository
{
    public partial class QueryStub : IQuery
    {
        private IReadOnlyCollection<Recipe> recipes;

        public QueryStub()
        {
            PopulateRecipes();
        }

        public void AddIngredient(Ingredient ingredient)
        {
            throw new System.NotImplementedException();
        }

        public void AddRecipe(Recipe recipe)
        {
            throw new System.NotImplementedException();
        }

        public void AddRecipeCategory(RecipeCategory category)
        {
            throw new System.NotImplementedException();
        }

        public void CookRecipe(Recipe recipe)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteRecipe(Recipe recipe)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteRecipeCategory(RecipeCategory category)
        {
            throw new System.NotImplementedException();
        }

        public IReadOnlyCollection<Recipe> GetAvailableRecipes()
        {
            throw new System.NotImplementedException();
        }

        public ShoppingList GetShoppingList(ICollection<Recipe> recipes)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateIngredientQuantity(int quantity, Ingredient ingredient)
        {
            throw new System.NotImplementedException();
        }

        private void PopulateRecipes()
        {
            //add some recipes here
        }
    }
}
