using CIS560_RecipeManager.Pantry;
using System.Collections.Generic;

namespace CIS560_RecipeManager.RecipeManager
{
    public class RecipeController
    {
        private IQuery _queryRepository;
        private RecipeInventory _recipeInventory;
        private MyPantry _pantry;
        private AddRecipeViewModel _viewModel;

        public RecipeController(
            IQuery query, 
            RecipeInventory recipeInventory,
            MyPantry pantry)
        {
            _queryRepository = query;
            _recipeInventory = recipeInventory;
            _pantry = pantry;
        }

        public void LaunchRecipeForm()
        {
            new uiRecipe(LaunchAddRecipeForm, _recipeInventory).Show();
        }

        public void LaunchAddRecipeForm()
        {
            var ingredients = new List<Ingredient>();
            foreach (var i in _pantry.PantryContents)
            {
                ingredients.Add(i.Key);
            }
            _viewModel = new AddRecipeViewModel(
                ingredients,
                new Dictionary<Ingredient, int>());

            new uiAddRecipeForm(AddRecipe, LaunchAddIngredientForm, _viewModel).Show();
        }

        public void CookRecipe(Recipe recipe)
        {
            foreach (KeyValuePair<Ingredient, int> item in recipe.MeasuredIngredients)
            {
                //If we don't allow the user to delete Ingredients, there should
                //never be an Ingredient that doesn't exist in the Pantry, so we should
                //just let the IDictionary through a KeyNotFoundException
                int updatedQuantity = (_pantry.PantryContents[item.Key] -= item.Value);

                //update the Ingredient quantity in the database
                _queryRepository.UpdateIngredientQuantity(updatedQuantity,item.Key);
            }
        }

        public void AddRecipe(string recipeName, string recipeDescription, IDictionary<Ingredient, int> measuredIngredients)
        {
            Recipe recipe = _queryRepository.CreateRecipe(recipeName, recipeDescription, measuredIngredients);
            _recipeInventory.AddRecipe(recipe);
        }

        public void LaunchAddIngredientForm()
        {
            new uiAddIngredient(CreateIngredient).Show();
        }

        public void CreateIngredient(string name, string unitOfMeasure, int quantity)
        {
            Ingredient ingredient = _queryRepository.CreateIngredient(name, unitOfMeasure, quantity);
            _pantry.AddToPantry(ingredient, quantity);
            _viewModel.AddIngredientToTotal(ingredient);
        }
    }
}
