using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

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
        }

        public void AddRecipes(ICollection<Recipe> recipes)
        {
            foreach (Recipe r in recipes)
            {
                RecipeCollection.Add(r);
            }
        }

        public void AddRecipe(
            string name, 
            string description,
            RecipeCategory category,
            IDictionary<Ingredient, int> measuredIngredients)
        {
            Recipe recipe = _query.CreateRecipe(name, description, category, measuredIngredients);
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

        public RecipeCategory AddRecipeCategory(string name)
        {
            return _query.CreateRecipeCategory(name);
        }
    }
}
