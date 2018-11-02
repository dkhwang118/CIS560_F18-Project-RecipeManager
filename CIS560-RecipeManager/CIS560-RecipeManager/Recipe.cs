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

namespace CIS560_RecipeManager
{
    public class Recipe
    {
        public int RecipeID { get; }
        
        public string RecipeName { get; }

        public string RecipeDescription { get; }

        public int CategoryID { get; }

        public Recipe(int rID, string rName)
        {
            RecipeID = rID;
            RecipeName = rName;
        }
    }
}
