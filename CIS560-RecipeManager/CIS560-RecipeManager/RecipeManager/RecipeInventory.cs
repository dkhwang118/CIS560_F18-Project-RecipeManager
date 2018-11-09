using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_RecipeManager.RecipeManager
{
    public class RecipeInventory
    {
        public ICollection<Recipe> RecipeCollection {get;}

        public RecipeInventory()
        {
            RecipeCollection = new List<Recipe>();
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
