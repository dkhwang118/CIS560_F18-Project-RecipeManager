using CIS560_RecipeManager.RecipeManager;
using System.Collections.Generic;

namespace CIS560_RecipeManager
{
    public interface IQuery
    {
        Recipe CreateRecipe(string recipeName, string recipeDescription, int categoryId, IDictionary<Ingredient, int> measuredIngredients);

        void DeleteRecipe(Recipe recipe);

        Ingredient CreateIngredient(string name, string unitOfMeasure, int quantity);

        IReadOnlyCollection<Recipe> GetAvailableRecipes();

        ShoppingList GetShoppingList(ICollection<Recipe> recipes);

        void UpdateIngredientQuantity(int quantity, Ingredient ingredient);

        void AddRecipeCategory(string categoryName);

        void DeleteRecipeCategory(string categoryName);

        void CookRecipe(Recipe recipe);
    }
}
