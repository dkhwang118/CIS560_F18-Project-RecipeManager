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
            RecipeCategories.Add(new RecipeCategory(0, "Desserts"));
        }

        public void AddIngredientToTotal(Ingredient i)
        {
            TotalIngredients.Add(i);
        }
    }
}
