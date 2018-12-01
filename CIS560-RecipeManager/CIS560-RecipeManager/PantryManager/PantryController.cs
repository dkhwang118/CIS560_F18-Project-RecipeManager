using CIS560_RecipeManager.Pantry;
using System;
namespace CIS560_RecipeManager.PantryManager
{
    public class PantryController
    {
        public delegate void CreateIngredientDelegate(string name, string unitOfMeasure, int quantity, int unitPriceInCents);
        private MyPantry _pantry;

        public PantryController(MyPantry pantry)
        {
            _pantry = pantry;
        }

        public void LaunchPantryForm()
        {
            new uiPantry(
                LaunchAddIngredientForm,_pantry).ShowDialog();
        }

        public void LaunchAddIngredientForm()
        {
            new uiAddIngredient(CreateIngredient).ShowDialog();
        }

        public void CreateIngredient(string name, string unitOfMeasure, int quantity, int unitPriceInCents)
        {
            _pantry.CreateIngredient(name, unitOfMeasure, quantity, unitPriceInCents);
        }
    }
}
