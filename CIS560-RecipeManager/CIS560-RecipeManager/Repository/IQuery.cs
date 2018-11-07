using System.Collections.Generic;

namespace CIS560_RecipeManager
{
    public interface IQuery
    {
        void AddRecipe(Recipe recipe);

        void DeleteRecipe(Recipe recipe);

        Ingredient AddIngredient(string ingredientName, string unitOfMeasurement, int unitCount);

        IReadOnlyCollection<Recipe> GetAvailableRecipes();

        ShoppingList GetShoppingList(ICollection<Recipe> recipes);

        void UpdateIngredientQuantity(int quantity, Ingredient ingredient);

        void AddRecipeCategory(RecipeCategory category);

        void DeleteRecipeCategory(RecipeCategory category);

        void CookRecipe(Recipe recipe);
    }
}
