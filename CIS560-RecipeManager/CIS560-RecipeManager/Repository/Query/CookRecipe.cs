/*
 * CookRecipe.cs
 * partial Query class holding the CookRecipe method
 */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Transactions;
using CIS560_RecipeManager.RecipeManager;

namespace CIS560_RecipeManager.Repository
{
    public partial class Query : IQuery
    {
        /// <summary>
        /// Subtracts the ingredient(s) quantity as defined by the given recipe from the PantryItem Table
        /// </summary>
        /// <param name="recipe">Recipe to "Cook"</param>
        public void CookRecipe(Recipe recipe)
        {
            // Loop through each ingredient and update quantity
            foreach (KeyValuePair<Ingredient, int> kvp in recipe.MeasuredIngredients)
            {
                UpdateIngredientQuantity((kvp.Value*-1), kvp.Key); // subtract the quantity given by recipe from the ingredient quantity in pantry
            }
            
        }
    }
}
