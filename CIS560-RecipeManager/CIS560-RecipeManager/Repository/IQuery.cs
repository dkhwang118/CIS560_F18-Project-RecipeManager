using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_RecipeManager
{
    public interface IQuery
    {
        void AddRecipe(Recipe recipe);

        void DeleteRecipe(Recipe recipe);

        void AddIngredient(Ingredient ingredient);

        IReadOnlyCollection<Recipe> GetAvailableRecipes();

        ShoppingList GetShoppingList(ICollection<Recipe> recipes);

        void UpdateIngredientQuantity(int quantity, Ingredient ingredient);

        void AddRecipeCategory(RecipeCategory category);

        void DeleteRecipeCategory(RecipeCategory category);

        void CookRecipe(Recipe recipe);
    }
}
