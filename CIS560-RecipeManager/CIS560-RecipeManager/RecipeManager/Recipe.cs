/**
 * Recipe.cs
 * Class representing a recipe object
 * Authors: CIS560 Project Team 1
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_RecipeManager;

namespace CIS560_RecipeManager.RecipeManager
{
    public class Recipe
    {
        public int Id { get; }
        
        public string Name { get; }

        public string Description { get; }

        public int CategoryName { get; }

        public int CategoryID { get; }

        public IDictionary<Ingredient, int> MeasuredIngredients { get; }

        public Recipe(
            int id, 
            string name,
            string description,
            IDictionary<Ingredient, int> measuredIngredients)
        {
            Id = id;
            Name = name;
            Description = description;
            MeasuredIngredients = measuredIngredients;
        }
    }
}
