using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CIS560_RecipeManager.RecipeManager
{
    public class EditRecipeViewModel
    {
        public BindingList<Ingredient> TotalIngredients { get; }

        public BindingList<Ingredient> RecipeIngredients { get; }

        public Recipe CurrentRecipe { get; }

        public EditRecipeViewModel(
            ICollection<Ingredient> totalIngredients, 
            Recipe recipe)
        {
            TotalIngredients = new BindingList<Ingredient>();
            RecipeIngredients = new BindingList<Ingredient>();
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
                }
            }
        }

        public void AddIngredientToTotal(Ingredient i)
        {
            TotalIngredients.Add(i);
        }
    }
}
