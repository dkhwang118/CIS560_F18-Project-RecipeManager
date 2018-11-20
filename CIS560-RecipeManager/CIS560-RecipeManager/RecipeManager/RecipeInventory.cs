using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CIS560_RecipeManager.RecipeManager
{
    public class RecipeInventory
    {
        private IQuery _query;

        public BindingList<Recipe> RecipeCollection {get;}

        public RecipeInventory(IQuery query)
        {
            _query = query;
            RecipeCollection = new BindingList<Recipe>();
            Dictionary<Ingredient, int> dict = new Dictionary<Ingredient, int>();
            dict.Add(new Ingredient(1, "Potato", "Quantity"), 5);
            RecipeCollection.Add(new Recipe(0, "test","directions", dict));
        }

        public void AddRecipes(ICollection<Recipe> recipes)
        {
            foreach (Recipe r in recipes)
            {
                RecipeCollection.Add(r);
            }
        }

        public void AddRecipe(string name, string description, IDictionary<Ingredient, int> measuredIngredients)
        {
            Recipe recipe = _query.CreateRecipe(name, description, measuredIngredients);
            RecipeCollection.Add(recipe);
        }

        public void DeleteRecipe(Recipe recipe)
        {
            RecipeCollection.Remove(recipe);
            _query.DeleteRecipe(recipe);
        }

        public void UpdateRecipe(Recipe recipe)
        {
            _query.UpdateRecipe(recipe);
        }

        public ICollection<RecipeCategory> GetAllRecipeCategories()
        {
            return _query.GetRecipeCategories();
        }
    }
}
