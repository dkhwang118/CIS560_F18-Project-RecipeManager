using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CIS560_RecipeManager.RecipeManager
{
    public class RecipeInventory
    {
        private IQuery _query;
        private ICollection<Recipe> _totalRecipes;

        public BindingList<Recipe> VisibleRecipes {get;}

        public RecipeInventory(IQuery query)
        {
            _query = query;
            VisibleRecipes = new BindingList<Recipe>();
            PopulateVisibleRecipes();
        }

        private void PopulateVisibleRecipes()
        {
            _totalRecipes = _query.GetAllRecipes();
            foreach (var r in _totalRecipes)
            {
                VisibleRecipes.Add(r);
            }
        }

        public void AddRecipe(
            string name, 
            string description,
            RecipeCategory category,
            IDictionary<Ingredient, int> measuredIngredients)
        {
            Recipe recipe = _query.CreateRecipe(name, description, category, measuredIngredients);
            _totalRecipes.Add(recipe);
            VisibleRecipes.Add(recipe);
        }

        public void DeleteRecipe(Recipe recipe)
        {
            _totalRecipes.Remove(recipe);
            VisibleRecipes.Remove(recipe);
            _query.DeleteRecipe(recipe);
        }

        public void UpdateRecipe(Recipe recipe)
        {
            _query.UpdateRecipe(recipe);
        }

        public ICollection<RecipeCategory> GetAllRecipeCategories()
        {
            return _query.GetRecipeCategories();
        }

        public RecipeCategory AddRecipeCategory(string name)
        {
            return _query.CreateRecipeCategory(name);
        }

        public void OnlyDisplayAvailableRecipes()
        {
            var available = _query.GetAvailableRecipes();
            VisibleRecipes.Clear();
            foreach (var r in available)
            {
                VisibleRecipes.Add(r);
            }
        }

        public void DisplayAllRecipes()
        {
            VisibleRecipes.Clear();
            foreach (var r in _totalRecipes)
            {
                VisibleRecipes.Add(r);
            }
        }
    }
}
