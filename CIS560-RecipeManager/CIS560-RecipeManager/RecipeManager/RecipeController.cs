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
                DeleteRecipe,
                CookRecipe,
                _recipeInventory).Show();
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

            new uiEditRecipeForm(AddRecipe, UpdateRecipe, AddRecipeCategory, LaunchAddIngredientForm, _viewModel).Show();
        }

        public void LaunchEditRecipeForm(Recipe recipe)
        {
            var ingredients = new List<Ingredient>();
            foreach (var i in _pantry.PantryContents)
            {
                ingredients.Add(i.Key);
            }

            _viewModel = new EditRecipeViewModel(ingredients, _recipeInventory.GetAllRecipeCategories(), recipe);
            new uiEditRecipeForm(AddRecipe, UpdateRecipe, AddRecipeCategory, LaunchAddIngredientForm, _viewModel).Show();
        }

        public void DeleteRecipe(Recipe recipe)
        {
            _recipeInventory.DeleteRecipe(recipe);
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

        public void AddRecipe(
            string recipeName, 
            string recipeDescription,
            RecipeCategory category,
            IDictionary<Ingredient, int> measuredIngredients)
        {
            _recipeInventory.AddRecipe(
                recipeName, 
                recipeDescription, 
                category,
                measuredIngredients);
        }

        public void UpdateRecipe(Recipe recipe)
        {
            _recipeInventory.UpdateRecipe(recipe);
        }

        public RecipeCategory AddRecipeCategory(string name)
        {
            return _recipeInventory.AddRecipeCategory(name);
        }

        public void LaunchAddIngredientForm()
        {
            new uiAddIngredient(CreateIngredient).Show();
        }

        public void CreateIngredient(string name, string unitOfMeasure, int quantity)
        {
            var ingredient = _pantry.CreateIngredient(name, unitOfMeasure, quantity);
            _viewModel.AddIngredientToTotal(ingredient);
        }
    }
}
