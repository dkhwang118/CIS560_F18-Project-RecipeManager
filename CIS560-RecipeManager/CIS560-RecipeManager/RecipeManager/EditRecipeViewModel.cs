using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CIS560_RecipeManager.RecipeManager
{
    public class EditRecipeViewModel
    {
        public BindingList<Ingredient> TotalIngredients { get; }

        public BindingList<Ingredient> RecipeIngredients { get; }

        public List<int> IngredientQuantities { get; }

        public BindingList<RecipeCategory> RecipeCategories { get; }

        public Recipe CurrentRecipe { get; }

        public EditRecipeViewModel(
            ICollection<Ingredient> totalIngredients, 
            ICollection<RecipeCategory> recipeCategories,
            Recipe recipe)
        {
            TotalIngredients = new BindingList<Ingredient>();
            RecipeIngredients = new BindingList<Ingredient>();
            IngredientQuantities = new List<int>();
            CurrentRecipe = recipe;

            foreach (Ingredient i in totalIngredients)
            {
                TotalIngredients.Add(i);
            }

            if (recipe != null)
            {
                foreach (var kvp in recipe.MeasuredIngredients)
                {
                    RecipeIngredients.Add(kvp.Key);
                    IngredientQuantities.Add(kvp.Value);
                }
            }

            RecipeCategories = new BindingList<RecipeCategory>();
            foreach (var c in recipeCategories)
            {
                RecipeCategories.Add(c);
            }
        }

        public void AddIngredientToTotal(Ingredient i)
        {
            TotalIngredients.Add(i);
        }
    }
}
