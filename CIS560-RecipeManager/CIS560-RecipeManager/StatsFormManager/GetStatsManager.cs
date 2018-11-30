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

        private void PopulateDGV(int dataTypeParam)
        {
            // method to update the DGV with query information.
        }

    }
}
