using System;
namespace CIS560_RecipeManager.PantryManager
{
    public class PantryController
    {
        private IQuery QueryRepository;

        public PantryController(IQuery query)
        {
            QueryRepository = query;
        }

        public void LaunchPantryForm()
        {
            new uiPantry().Show();
        }
    }
}
