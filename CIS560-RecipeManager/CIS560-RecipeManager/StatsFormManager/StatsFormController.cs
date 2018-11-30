using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_RecipeManager.RecipeManager;

namespace CIS560_RecipeManager.StatsFormManager
{
    public class StatsFormController
    {
        private IQuery _query;
        private GetStatsManager _getStatsManager;

        public StatsFormController(IQuery query)
        {
            _query = query;
            _getStatsManager = new GetStatsManager(query);
        }

        public void LaunchStatsForm()
        {
            (new uiStats(LaunchNotCookedLatelyForm,
                            LaunchRecipeRatingsForm)
                            ).ShowDialog();
        }

        public void LaunchNotCookedLatelyForm()
        {
            new uiNotCookedLatelyForm(_getStatsManager).ShowDialog();
        }

        public void LaunchRecipeRatingsForm()
        {
            new uiRecipeRatingsForm(_getStatsManager).ShowDialog();
        }
    }
}
