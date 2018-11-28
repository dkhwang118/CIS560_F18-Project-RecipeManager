using CIS560_RecipeManager.Pantry;
using System.Collections.Generic;

namespace CIS560_RecipeManager.RecipeManager
{
    public class RecipeController
    {
        private RecipeInventory _recipeInventory;
        private MyPantry _pantry;
        private EditRecipeViewModel _viewModel;

        public RecipeController(
            RecipeInventory recipeInventory,
            MyPantry pantry)
        {
            _recipeInventory = recipeInventory;
            _pantry = pantry;
        }

        public void LaunchRecipeForm()
        {
            new uiRecipe(
                LaunchAddRecipeForm,
                LaunchEditRecipeForm,
                _recipeInventory.OnlyDisplayAvailableRecipes,
                _recipeInventory.DisplayAllRecipes,
                _recipeInventory.RateRecipe,
                _recipeInventory.DeleteRecipe,
                CookRecipe,
                _recipeInventory).ShowDialog();
        }

        public void LaunchAddRecipeForm()
        {
            var ingredients = new List<Ingredient>();
            foreach (var i in _pantry.PantryContents)
            {
                ingredients.Add(i.Key);
            }
            _viewModel = new EditRecipeViewModel(
                ingredients,
                _recipeInventory.GetAllRecipeCategories(),
                null);

            new uiEditRecipeForm(
                _recipeInventory.AddRecipe, 
                _recipeInventory.UpdateRecipe, 
                _recipeInventory.AddRecipeCategory, 
                LaunchAddIngredientForm, 
                _viewModel)
                    .ShowDialog();
        }

        public void LaunchEditRecipeForm(Recipe recipe)
        {
            var ingredients = new List<Ingredient>();
            foreach (var i in _pantry.PantryContents)
            {
                ingredients.Add(i.Key);
            }

            _viewModel = new EditRecipeViewModel(ingredients, _recipeInventory.GetAllRecipeCategories(), recipe);
            new uiEditRecipeForm(
                _recipeInventory.AddRecipe, 
                _recipeInventory.UpdateRecipe, 
                _recipeInventory.AddRecipeCategory, 
                LaunchAddIngredientForm, 
                _viewModel)
                    .ShowDialog();
        }

        public void CookRecipe(Recipe recipe)
        {
            foreach (KeyValuePair<Ingredient, int> item in recipe.MeasuredIngredients)
            {
                //If we don't allow the user to delete Ingredients, there should
                //never be an Ingredient that doesn't exist in the Pantry, so we should
                //just let the IDictionary throw a KeyNotFoundException
                int updatedQuantity = _pantry.PantryContents[item.Key] - item.Value;

                //update the Ingredient quantity in the pantry
                _pantry.UpdateIngredientQuantity(updatedQuantity, item.Key);
            }
        }

        public void LaunchAddIngredientForm()
        {
            new uiAddIngredient(CreateIngredient).Show();
        }

        public void CreateIngredient(string name, string unitOfMeasure, int quantity, int unitPriceInCents)
        {
            var ingredient = _pantry.CreateIngredient(name, unitOfMeasure, quantity, unitPriceInCents);
            _viewModel.AddIngredientToTotal(ingredient);
        }
    }
}
