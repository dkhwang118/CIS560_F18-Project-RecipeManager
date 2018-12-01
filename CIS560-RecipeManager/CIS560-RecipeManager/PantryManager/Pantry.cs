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

        public IDictionary<Ingredient, int> PantryContents { get; } //a dictionary containing key value pairs of what is in the pantry
                                                                    //Ingredient for the ingredients
                                                                    //the integer represents the quantity of the ingredient
        public BindingList<Ingredient> IngredientList { get; }

        public List<int> IngredientQuantities { get; }


        public MyPantry(IQuery query)
        {
            _query = query;
            IngredientList = new BindingList<Ingredient>();
            IngredientQuantities = new List<int>();
            PantryContents = _query.GetPantryContents();
            PopulateBindingLists();
        }

        public void PopulateBindingLists()
        {
            foreach (var kvp in PantryContents)
            {
                IngredientList.Add(kvp.Key);
                IngredientQuantities.Add(kvp.Value);
            }
        }

        //updates the pantry contents with an ingredient and quantity
        public Ingredient CreateIngredient(string name, string unitOfMeasure, int quantity, int unitPriceInCents)
        {
            Ingredient ingredient = _query.CreateIngredient(name, unitOfMeasure, quantity, unitPriceInCents);
            PantryContents.Add(ingredient, quantity);
            return ingredient;
        }

        public void UpdateIngredientQuantity(Ingredient ingredient, int quantity)
        {
            PantryContents[ingredient] = quantity;
            _query.UpdateIngredientQuantity(quantity, ingredient);
        }
    }
}


