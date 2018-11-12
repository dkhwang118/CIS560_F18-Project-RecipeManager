using CIS560_RecipeManager.Pantry;
using System;
namespace CIS560_RecipeManager.PantryManager
{
    public class PantryController
    {
        public delegate void CreateIngredientDelegate(string name, string unitOfMeasure, int quantity);

        private IQuery _queryRepository;
        private MyPantry _pantry;

        public PantryController(IQuery query, MyPantry pantry)
        {
            _queryRepository = query;
            _pantry = pantry;
        }

        public void LaunchPantryForm()
        {
            new uiPantry(LaunchAddIngredientForm).Show();
        }

        public void LaunchAddIngredientForm()
        {
            new uiAddIngredient(CreateIngredient).Show();
        }

        public void CreateIngredient(string name, string unitOfMeasure, int quantity)
        {
            Ingredient ingredient = _queryRepository.CreateIngredient(name, unitOfMeasure, quantity);
            _pantry.AddToPantry(ingredient, quantity);
        }
    }
}
