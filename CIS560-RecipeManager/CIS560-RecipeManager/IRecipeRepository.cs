using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_RecipeManager
{
    
    public interface IRecipeRepository
    {
        IReadOnlyList<Recipe> GetRecipeList();

        Recipe GetRecipe(int recipeID);

        Recipe CreateRecipe(string recipeName, string recipeDesc);
    }
}
