using System;
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

        public Ingredient AddIngredient(string ingredientName, string unitOfMeasurement, int initialUnitAmount)
        {
            throw new NotImplementedException();
        }

        public void AddRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public void AddRecipeCategory(RecipeCategory category)
        {
            throw new NotImplementedException();
        }

        public void CookRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecipeCategory(RecipeCategory category)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyCollection<Recipe> GetAvailableRecipes()
        {
            throw new NotImplementedException();
        }

        public ShoppingList GetShoppingList(ICollection<Recipe> recipes)
        {
            throw new NotImplementedException();
        }

        public void UpdateIngredientQuantity(int quantity, Ingredient ingredient)
        {
            throw new NotImplementedException();
        }

        private void PopulateRecipes()
        {
            //add some recipes here
        }
    }
}
