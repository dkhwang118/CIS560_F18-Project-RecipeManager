using CIS560_RecipeManager.RecipeManager;
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

        public Ingredient CreateIngredient(string name, string unit, int quantity)
        {
            return new Ingredient(0, name, unit);
        }

        public void AddRecipeCategory(RecipeCategory category)
        {
            //add recipe category
        }

        public void CookRecipe(Recipe recipe)
        {
            //cook recipe
        }

        public Recipe CreateRecipe(string recipeName, string recipeDescription, IDictionary<Ingredient, int> measuredIngredients)
        {
            return new Recipe(0, recipeName, measuredIngredients);
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
