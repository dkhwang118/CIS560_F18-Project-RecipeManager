using CIS560_RecipeManager.RecipeManager;
using System;
using System.Collections.Generic;

namespace CIS560_RecipeManager.Repository
{
    public partial class QueryStub : IQuery
    {
        private IReadOnlyCollection<Recipe> recipes;

        public QueryStub()
        {
            PopulateRecipes();
        }

        public Ingredient CreateIngredient(string name, string unit, int quantity)
        {
            return new Ingredient(0, name, unit);
        }

        public void AddRecipeCategory(RecipeCategory category)
        {
            //add recipe category
        }

        public void CookRecipe(Recipe recipe)
        {
            //cook recipe
        }

        public Recipe CreateRecipe(string recipeName, string recipeDescription, RecipeCategory category, IDictionary<Ingredient, int> measuredIngredients)
        {
            return new Recipe(0, recipeName, recipeDescription, category, measuredIngredients);
        }

        public void DeleteRecipe(Recipe recipe)
        {
            //delete recipe
        }

        public void DeleteRecipeCategory(RecipeCategory category)
        {
            //delete recipe category
        }

        public IReadOnlyCollection<Recipe> GetAvailableRecipes()
        {
            List<Recipe> list = new List<Recipe>();

            Dictionary<Ingredient, int> d1 = new Dictionary<Ingredient, int>();
            d1.Add(new Ingredient(1, "Potato", "Quantity"), 5);
            Recipe r1 = new Recipe(0, "Baked Potato", "directions", new RecipeCategory(0, "Entrees"), d1);
            list.Add(r1);

            Dictionary<Ingredient, int> d2 = new Dictionary<Ingredient, int>();
            d2.Add(new Ingredient(2, "Macaroni", "Box"), 1);
            d2.Add(new Ingredient(3, "Cheese", "Ounce"), 2);
            Recipe r2 = new Recipe(0, "Mac & Cheese","directions", new RecipeCategory(0, "Entrees"), d1);
            list.Add(r2);

            return list;
        }

        public ShoppingList GetShoppingList(ICollection<Recipe> recipes)
        {
            ShoppingList s = new ShoppingList(0, "ShoppingList1");
            foreach (Recipe r in recipes)
            {
                foreach (KeyValuePair<Ingredient,int> kvp in r.MeasuredIngredients)
                {
                    s.AddShoppingListItem(kvp.Key, kvp.Value);
                    //Todo : subtract the quantity from the pantry
                }
            }
            return s;
        }

        public void UpdateIngredientQuantity(int quantity, Ingredient ingredient)
        {
            //update Ingredient quantity
        }

        private void PopulateRecipes()
        {
            //add some recipes here
        }

        public void UpdateRecipe(Recipe recipe)
        {
            //update recipe
        }

        public ICollection<RecipeCategory> GetRecipeCategories()
        {
            var categories = new List<RecipeCategory>();
            categories.Add(new RecipeCategory(0, "Entrees"));
            categories.Add(new RecipeCategory(1, "Desserts"));
            return categories;
        }
    }
}
