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
    public class Recipe : IComparable<Recipe>
    {
        public int Id { get; }

        public string Name { get; set; }

        public string Description { get; set; }

        public RecipeCategory Category {get; set;}

        public IDictionary<Ingredient, int> MeasuredIngredients { get; private set; }

        public BindingList<RecipeIngredient> IngredientBindingList { get; }

        public Recipe(
            int id, 
            string name,
            string description,
            RecipeCategory category,
            IDictionary<Ingredient, int> measuredIngredients)
        {
            Id = id;
            Name = name;
            Description = description;
            Category = category;
            MeasuredIngredients = measuredIngredients;
            IngredientBindingList = new BindingList<RecipeIngredient>();
            PopulateMeasuredIngredients(measuredIngredients);
        }

        public void PopulateMeasuredIngredients(
            IDictionary<Ingredient, int> measuredIngredients)
        {
            IngredientBindingList.Clear();

            foreach (KeyValuePair<Ingredient, int> kvp in measuredIngredients)
            {
                IngredientBindingList.Add(
                    new RecipeIngredient(kvp.Key.Id, kvp.Key.Name, kvp.Key.Unit, kvp.Value, kvp.Key.PriceInCents));
            }

            MeasuredIngredients = measuredIngredients;
        }

        public override string ToString()
        {
            return $"Recipe(id: {Id}, name: {Name}, description: {Description}, measuredIngredients: {MeasuredIngredients})";
        }

        public int CompareTo(Recipe other)
        {
            return string.Compare(Category.Name, other.Category.Name);
        }
    }
}
