using CIS560_RecipeManager.RecipeManager;
using System.Collections.Generic;

namespace CIS560_RecipeManager
{
    public interface IQuery
    {
        void UpdateRecipe(Recipe recipe);

        Recipe CreateRecipe(string recipeName, string recipeDescription, RecipeCategory category, IDictionary<Ingredient, int> measuredIngredients, int? recipeRating = 0);

        void DeleteRecipe(Recipe recipe);

        Ingredient CreateIngredient(string name, string unitOfMeasure, int quantity, int UnitPriceInCents);

        IReadOnlyCollection<Recipe> GetAvailableRecipes();

        ICollection<Recipe> GetAllRecipes();

        ShoppingList CreateShoppingList(string shoppingListName, ICollection<Recipe> recipes);

        ICollection<ShoppingList> GetAllShoppingLists();

        void UpdateIngredientQuantity(int quantity, Ingredient ingredient);

        RecipeCategory CreateRecipeCategory(string name);

        void DeleteRecipeCategory(RecipeCategory category);

        void CookRecipe(Recipe recipe);

        ICollection<RecipeCategory> GetRecipeCategories();

        void RateRecipe(Recipe recipe, int recipeRating);

        RecipeCategory GetRecipeCategory(int recipeId);

        IDictionary<Ingredient,int> GetPantryContents();

        ICollection<Recipe> GetAffordableRecipes(int maxAmountToSpendInCents);

        ICollection<Recipe> GetTopRatedRecipesWithTies(int recipesPerCategory);

        IDictionary<RecipeCategory, decimal> GetAvgRatingPerCategory();

        IDictionary<Recipe, string> GetRecipesCookedLeastRecent();

        ICollection<Recipe> GetRecipesNotCooked();
    }
}
