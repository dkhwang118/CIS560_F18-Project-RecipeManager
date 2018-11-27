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
        private IQuery _query;

        public Dictionary<Ingredient, int> PantryContents { get; } //a dictionary containing key value pairs of what is in the pantry
        //Ingredient for the ingredients
        //the integer represents the quantity of the ingredient


        public MyPantry(IQuery query)
        {
            _query = query;
            PantryContents = new Dictionary<Ingredient, int>();
            //todo: populate pantry with items from _query
        }

        //updates the pantry contents with an ingredient and quantity
        public Ingredient CreateIngredient(string name, string unitOfMeasure, int quantity, int unitPriceInCents)
        {
            Ingredient ingredient = _query.CreateIngredient(name, unitOfMeasure, quantity, unitPriceInCents);
            PantryContents.Add(ingredient, quantity);
            return ingredient;
        }

        public void UpdateIngredientQuantity(int quantity, Ingredient ingredient)
        {
            PantryContents[ingredient] = quantity;
            _query.UpdateIngredientQuantity(quantity, ingredient);
        }
    }
}


