using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

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

        public void OnlyDisplayBudgetRecipes(int max)
        {
            var budget = _query.GetAffordableRecipes(max * 100);
            VisibleRecipes.Clear();
            foreach(var r in budget)
            {
                VisibleRecipes.Add(r);
            }
        }

        public void OnlyDisplayAvailableAndBudgetRecipes(int max)
        {
            var available = _query.GetAvailableRecipes();
            var budget = _query.GetAffordableRecipes(max * 100);
            VisibleRecipes.Clear();
            foreach (var r in _totalRecipes)
            {
                if(available.Any(x => x.Id == r.Id &&budget.Any(y => y.Id == r.Id)))
                {
                    VisibleRecipes.Add(r);
                }
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

        public void RateRecipe(Recipe recipe, int rating)
        {
            recipe.Rating = rating;
            _query.RateRecipe(recipe, rating);
        }

        public void CookRecipe(Recipe recipe)
        {
            _query.CookRecipe(recipe);
        }
    }
}
