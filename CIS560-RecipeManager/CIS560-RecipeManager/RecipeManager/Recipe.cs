/**
 * Recipe.cs
 * Class representing a recipe object
 * Authors: CIS560 Project Team 1
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public BindingList<BindingIngredient> IngredientBindingList { get; }

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
            IngredientBindingList = new BindingList<BindingIngredient>();
            PopulateMeasuredIngredients(measuredIngredients);
        }

        private void PopulateMeasuredIngredients(
            IDictionary<Ingredient, int> measuredIngredients)
        {
            foreach (KeyValuePair<Ingredient, int> kvp in measuredIngredients)
            {
                IngredientBindingList.Add(
                    new BindingIngredient(kvp.Key.Name, kvp.Key.Unit, kvp.Value));
            }
        }

        public class BindingIngredient
        {
            public string Name { get; }
            public string Unit { get; }
            public int Quantity { get; }

            public BindingIngredient(string name, string unit, int quantity)
            {
                Name = name;
                Unit = unit;
                Quantity = quantity;
            }
        }


        public override string ToString()
        {
            return $"Recipe(id: {Id}, name: {Name}, description: {Description}, measuredIngredients: {MeasuredIngredients})";
        }
    }
}
