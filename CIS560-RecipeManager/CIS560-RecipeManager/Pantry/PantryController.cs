using System;
namespace CIS560_RecipeManager.PantryManager
{
    public class PantryController
    {
        public delegate void CreateIngredientDelegate(string name, string unitOfMeasure, int quantity);

        private IQuery _queryRepository;
        private Pantry _pantry;

        public PantryController(IQuery query, Pantry pantry)
        {
            _queryRepository = query;
            _pantry = pantry;
        }

        public void LaunchPantryForm()
        {
            new uiPantry(CreateIngredient).Show();
        }

        public void CreateIngredient(string name, string unitOfMeasure, int quantity)
        {
            Ingredient ingredient = _queryRepository.CreateIngredient(name, unitOfMeasure, quantity);
            _pantry.AddToPantry(ingredient, quantity);
        }
    }
}
