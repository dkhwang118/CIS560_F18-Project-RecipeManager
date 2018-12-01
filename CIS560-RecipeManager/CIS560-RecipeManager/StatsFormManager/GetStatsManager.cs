using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using CIS560_RecipeManager.RecipeManager;

namespace CIS560_RecipeManager.StatsFormManager
{
    public class GetStatsManager
    {
        private IQuery _query;
        private ICollection<Recipe> _totalRecipes;
        private ICollection<RecipeCategory> _totalCategories;

        public BindingList<Recipe> VisibleRecipes { get; }
        public BindingList<RecipeCategory> VisibleRecipeCategories { get; }

        public GetStatsManager(IQuery query)
        {
            _query = query;
        }

        public void PopulateDGV(int dataTypeParam)
        {
            // method to update the DGV with query information.
        }

        public IDictionary<string, string> GetLeastRecentlyCookedRecipes()
        {
            return _query.GetRecipesCookedLeastRecent();
        }

        public ICollection<Recipe> GetRecipesNotCooked()
        {
            return _query.GetRecipesNotCooked();
        }

        public ICollection<Recipe> GetTopRatedRecipesWithTies(int amtPerCategory)
        {
            return _query.GetTopRatedRecipesWithTies(amtPerCategory);
        }

    }
}
