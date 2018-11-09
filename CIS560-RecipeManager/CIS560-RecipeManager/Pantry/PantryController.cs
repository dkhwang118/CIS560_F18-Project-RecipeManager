using System;
namespace CIS560_RecipeManager.PantryManager
{
    public class PantryController
    {
        private IQuery _queryRepository;
        private Pantry _pantry;

        public PantryController(IQuery query, Pantry pantry)
        {
            _queryRepository = query;
            _pantry = pantry;
        }

        public void LaunchPantryForm()
        {
            new uiPantry().Show();
        }
    }
}
