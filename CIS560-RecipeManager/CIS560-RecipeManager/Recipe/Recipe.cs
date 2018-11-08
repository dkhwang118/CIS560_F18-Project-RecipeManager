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

namespace CIS560_RecipeManager
{
    public class Recipe
    {
        public int Id { get; }
        
        public string Name { get; }

        public string Description { get; }

        public int CategoryID { get; }

        public IDictionary<Ingredient, int> MeasuredIngredients { get; }

        public Recipe(int id, string name)
        {
            Id = id;
            Name = name;
            MeasuredIngredients = new Dictionary<Ingredient, int>();
        }

        bool CookRecipe()
        {
            Pantry p = new Pantry(); //test pantry
            Ingredient i = new Ingredient(123, "Flour", "cups");
            foreach (KeyValuePair<Ingredient, int> item in MeasuredIngredients)
            {
                  //if the item is in the pantry subtract the quantity
                  if (p.PantryContents.ContainsKey(item.Key))
                  {
                        p.PantryContents[item.Key] -= item.Value;
                  }
                  //else item not in pantry - cannot cook recipe
                  else
                  {
                       //
                  }
            }
            return true;
        }
    }
}
