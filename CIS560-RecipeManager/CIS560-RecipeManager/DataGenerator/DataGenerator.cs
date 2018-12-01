using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CIS560_RecipeManager.RecipeManager;
using CIS560_RecipeManager.Repository;


namespace CIS560_RecipeManager.DataGenerator
{
    static class DataGenerator
    {
        // Ingredient Configuration
        private static int minIngredientNameSize = 1;
        private static int maxIngredientNameSize = 2;

        private static int minQuantity = 0;
        private static int maxQuantity = 10;

        private static int minPrice = 0;
        private static int maxPrice = 1000;


        //Category Configuration
        private static int minCategoryNameSize = 1;
        private static int maxCategoryNameSize = 2;

        //Recipe Configuration
        private static int minRecipeNameSize = 1;
        private static int maxRecipeNameSize = 3;
        
        private static int minRecipeDescriptionSize = 1;
        private static int maxRecipeDescriptionSize = 30;

        private static double probOfNewlineInDescription = 0.1;

        private static List<string> measures = new List<string> {"cup", "quart", "unit", "pound", "kilogram",
            "ounce", "gallon", "barrel",
            "furlong", "inch", "pinch", "dash"};

        private static int minRecipeIngredients = 1;
        private static int maxRecipeIngredients = 10;


        private static int minRecipeIngredientQuantity = 1;
        private static int maxRecipeIngredientQuantity = 10;

        public static void GenerateAndInsertData()
        {
            throw new NotImplementedException("Data Generator not Implemented");
        }

        public static IList<Ingredient> GenerateIngredients(IQuery query, int numberOfIngredients)
        {
            List<string> words = Properties.Resources.wordlist.Split('\n').ToList();
            List<Ingredient> addedIngredientIds = new List<Ingredient>();
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
                addedIngredientIds.Add(ing);
            }

            return addedIngredientIds;
        }

        public static List<int> GenerateRecipeCategories(IQuery query, int numberOfCategories)
        {

            List<string> words = Properties.Resources.wordlist.Split('\n').ToList();
            List<int> addedCategoryIds = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < numberOfCategories; i++)
            {
                int numberOfWordsInName = rand.Next(minCategoryNameSize, maxCategoryNameSize + 1);
                string name = words
                    // Randomly order the list
                    // Not efficient
                    .OrderBy(_ => rand.NextDouble())
                    .Take(numberOfWordsInName)
                    .Aggregate((x, y) => x + " " + y);
                RecipeCategory ing = query.CreateRecipeCategory(name);
                addedCategoryIds.Add(ing.Id);
            }

            return addedCategoryIds;
        }

        public static List<Recipe> GenerateRecipe(IQuery query, int numberOfRecipes,
            IReadOnlyList<RecipeCategory> categoryIds, IReadOnlyList<Ingredient> ingredients)
        {

            List<string> words = Properties.Resources.wordlist.Split('\n').ToList();
            List<Recipe> addedRecipe = new List<Recipe>();
            Random rand = new Random();
            for (int i = 0; i < numberOfRecipes; i++)
            {
                int numberOfWordsInName = rand.Next(minRecipeNameSize, maxRecipeNameSize + 1);
                int numberOfWordsInDescription = rand.Next(minRecipeDescriptionSize, maxRecipeDescriptionSize + 1);
                string name = words
                    .OrderBy(_ => rand.NextDouble())
                    .Take(numberOfWordsInName)
                    .Aggregate((x, y) => x + " " + y);


                string description = words
                    .OrderBy(_ => rand.NextDouble())
                    .Take(numberOfWordsInName)
                    .Aggregate((x, y) => rand.NextDouble() < probOfNewlineInDescription ? x + "\n" + y : x + " " + y );

                RecipeCategory categoryId = categoryIds[rand.Next(categoryIds.Count)];

                Dictionary<Ingredient, int> recipeIngredients = new Dictionary<Ingredient, int>();
                int numberOfIngredients = rand.Next(minRecipeIngredients, Math.Max(maxRecipeIngredients + 1, ingredients.Count));

                foreach (var ing in ingredients
                    .OrderBy(_ => rand.NextDouble())
                    .Take(numberOfIngredients))
                {
                    int amount = rand.Next(minRecipeIngredientQuantity, maxRecipeIngredientQuantity + 1);
                    recipeIngredients[ing] = amount;
                }

                Recipe recipe = query.CreateRecipe(name, description, categoryId, recipeIngredients);
                addedRecipe.Add(recipe);
            }

            return addedRecipe;
        }
    }
}
