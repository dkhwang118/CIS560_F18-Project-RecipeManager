using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_RecipeManager.StatsFormManager
{
    public class StatsController
    {
        private IQuery _query;

        public StatsController(IQuery query)
        {
            _query = query;
        }

        public void LaunchStatsForm()
        {
            new uiStats();
        }
    }
}
