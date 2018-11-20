using CIS560_RecipeManager.RecipeManager;
using System.Collections.Generic;

namespace CIS560_RecipeManager
{
    public interface IQuery
    {
        void UpdateRecipe(Recipe recipe);

        Recipe CreateRecipe(string recipeName, string recipeDescription, IDictionary<Ingredient, int> measuredIngredients);

        void DeleteRecipe(Recipe recipe);

        Ingredient CreateIngredient(string name, string unitOfMeasure, int quantity);

        IReadOnlyCollection<Recipe> GetAvailableRecipes();

        ShoppingList GetShoppingList(ICollection<Recipe> recipes);

        void UpdateIngredientQuantity(int quantity, Ingredient ingredient);

        void AddRecipeCategory(RecipeCategory category);

        void DeleteRecipeCategory(RecipeCategory category);

        void CookRecipe(Recipe recipe);

        ICollection<RecipeCategory> GetRecipeCategories();
    }
}
