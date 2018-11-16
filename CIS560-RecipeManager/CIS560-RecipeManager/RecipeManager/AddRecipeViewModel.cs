using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CIS560_RecipeManager.RecipeManager
{
    public class AddRecipeViewModel
    {
        public BindingList<Ingredient> TotalIngredients { get; }

        public BindingList<Ingredient> RecipeIngredients { get; }

        public AddRecipeViewModel(ICollection<Ingredient> totalIngredients, IDictionary<Ingredient, int> measuredIngredients)
        {
            TotalIngredients = new BindingList<Ingredient>();
            RecipeIngredients = new BindingList<Ingredient>();

            foreach (Ingredient i in totalIngredients)
            {
                TotalIngredients.Add(i);
            }

            foreach(var kvp in measuredIngredients)
            {
                RecipeIngredients.Add(kvp.Key);
            }
        }

        public void AddIngredientToTotal(Ingredient i)
        {
            TotalIngredients.Add(i);
        }
    }
}
