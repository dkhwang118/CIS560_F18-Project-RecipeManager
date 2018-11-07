using System;
namespace CIS560_RecipeManager.PantryManager
{
    public class PantryController
    {
        private IQuery QueryRepository;
        private uiPantry pantry;

        public PantryController(IQuery query)
        {
            QueryRepository = query;
        }

        public void LaunchPantryForm()
        {
            (pantry = new uiPantry(QueryRepository)).Show();
            
        }
    }
}
