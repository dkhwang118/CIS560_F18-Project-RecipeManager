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

        public StatsFormController(IQuery query,
                                    GetStatsManager getStatsManager)
        {
            _query = query;
            _getStatsManager = getStatsManager;
        }

        public void LaunchStatsForm()
        {
            (new uiStats(LaunchNotCookedLatelyForm,
                            LaunchRecipeRatingsForm)
                            ).ShowDialog();
        }

        public void LaunchNotCookedLatelyForm()
        {
            new uiNotCookedLatelyForm().ShowDialog();
        }

        public void LaunchRecipeRatingsForm()
        {
            new uiRecipeRatingsForm().ShowDialog();
        }
    }
}
