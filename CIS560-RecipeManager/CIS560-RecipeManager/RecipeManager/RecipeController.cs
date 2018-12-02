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

        public void LaunchAddIngredientForm()
        {
            new uiAddIngredient(CreateIngredient).ShowDialog();
        }

        public void CreateIngredient(string name, string unitOfMeasure, int quantity, int unitPriceInCents)
        {
            var ingredient = _pantry.CreateIngredient(name, unitOfMeasure, quantity, unitPriceInCents);
            _viewModel.AddIngredientToTotal(ingredient);
        }

        public bool CookRecipe(Recipe recipe)
        {
            var success = _recipeInventory.TryCookRecipe(recipe);
            if (success)
            {
                _pantry.RefreshItems();
            }
            return success;
        }
    }
}
