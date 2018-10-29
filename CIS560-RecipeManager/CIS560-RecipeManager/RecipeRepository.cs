using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_RecipeManager
{
    public class RecipeRepository : IRecipeRepository
    {
        string connectionString = Properties.Settings.Default.RecipeDatabaseConnectionString;

        public Recipe CreateRecipe(string recipeName)
        {
            throw new NotImplementedException();
        }

        public Recipe GetRecipe(int recipeID)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Recipe> GetRecipeList()
        {
            throw new NotImplementedException();
        }
    }
}
