using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CIS560_RecipeManager.Repository;


namespace CIS560_RecipeManager.DataGenerator
{
    static class DataGenerator
    {
        private static int minIngredientNameSize = 1;
        private static int maxIngredientNameSize = 2;

        private static int minQuantity = 0;
        private static int maxQuantity = 10;

        private static int minPrice = 0;
        private static int maxPrice = 1000;

        private static List<string> measures = new List<string> {"cup", "quart", "unit", "pound", "kilogram",
            "ounce", "gallon", "barrel",
            "furlong", "inch", "pinch", "dash"};

        public static void GenerateAndInsertData()
        {
            throw new NotImplementedException("Data Generator not Implemented");
        }

        public static IList<int> GenerateIngredients(IQuery query, int numberOfIngredients)
        {
            List<string> words = Properties.Resources.wordlist.Split('\n').ToList();
            List<int> addedIngredientIds = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < numberOfIngredients; i++)
            {
                int numberOfWordsInName = rand.Next(minIngredientNameSize, maxIngredientNameSize + 1);
                string name = words
                    // Randomly order the list
                    // Not efficient
                    .OrderBy(_ => rand.NextDouble())
                    .Take(numberOfWordsInName)
                    .Aggregate((x, y) => x + " " + y);
                string measure = measures[rand.Next(measures.Count)];
                int startQuantity = rand.Next(minQuantity, maxQuantity + 1);
                int priceInCents = rand.Next(minPrice, maxPrice + 1);
                Ingredient ing = query.CreateIngredient(name, measure, startQuantity, priceInCents);
                addedIngredientIds.Add(ing.Id);
            }

            return addedIngredientIds;
        }

        public static List<int> GenerateRecipeCategories()
        {
            throw new NotImplementedException("Cannot make categories yet");
        }

        public static List<int> GenerateRecipe()
        {
            throw new NotImplementedException("I don't even know how recipes are made.");
        }
    }
}
