using System.Collections.Generic;

namespace CIS560_RecipeManager
{
    public class ShoppingList
    {
        public int Id { get; }

        public string Name { get; }

        public IDictionary<Ingredient, int> ShoppingListItems { get; }

        public ShoppingList(int id, string name)
        {
            Id = id;
            Name = name;
            ShoppingListItems = new Dictionary<Ingredient, int>();
        }

        public void AddShoppingListItem(Ingredient i, int quantity)
        {
            if (ShoppingListItems.Keys.Contains(i))
            {
                ShoppingListItems[i] += quantity;
            }
            else
            {
                ShoppingListItems.Add(i, quantity);
            }
        }
    }
}