using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_RecipeManager.RecipeManager
{
    public class AddRecipeViewModel
    {
        public BindingList<Ingredient> TotalIngredients { get; }

        public BindingList<RecipeIngredient> RecipeIngredients { get; }

        public AddRecipeViewModel(ICollection<Ingredient> totalIngredients, ICollection<RecipeIngredient> recipeIngredients)
        {
            TotalIngredients = new BindingList<Ingredient>();
            RecipeIngredients = new BindingList<RecipeIngredient>();

            foreach (Ingredient i in totalIngredients)
            {
                TotalIngredients.Add(i);
            }

            foreach(RecipeIngredient ri in recipeIngredients)
            {
                recipeIngredients.Add(ri);
            }
        }
    }
}
