/**
 * Pantry.cs
 * Class representing a pantry, which contains a list of 
 * ingredients that the are currently in the pantry. 
 * Authors: CIS560 Project Team 1
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_RecipeManager
{
    public class MyPantry
    {
        public Dictionary<Ingredient, int> PantryContents { get; } //a dictionary containing key value pairs of what is in the pantry
        //Ingredient for the ingredients
        //the integer represents the quantity of the ingredient


        public MyPantry()
        {
            PantryContents = new Dictionary<Ingredient, int>();
        }

        //updates the pantry contents with an ingredient and quantity
        public bool AddToPantry(Ingredient ingred, int quantity)
        {
            if (PantryContents.ContainsKey(ingred))
            {
                //update the quantity
                PantryContents[ingred] += quantity;
            }
            else
            {
                //add to pantry
                PantryContents.Add(ingred, quantity);
            }
            return true;
        }
    }
}


