using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CIS560_RecipeManager.RecipeManager
{
    public class RecipeInventory
    {
        public BindingList<Recipe> RecipeCollection {get;}

        public RecipeInventory()
        {
            RecipeCollection = new BindingList<Recipe>();
            RecipeCollection.Add(new Recipe(0, "test", new Dictionary<Ingredient, int>()));
        }

        public void AddRecipes(ICollection<Recipe> recipes)
        {
            foreach (Recipe r in recipes)
            {
                RecipeCollection.Add(r);
            }
        }

        public void AddRecipe(Recipe recipe)
        {
            RecipeCollection.Add(recipe);
        }
    }
}
