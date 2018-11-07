namespace CIS560_RecipeManager
{
    public class ShoppingList
    {
        public int Id { get; }

        public string Name { get; }

        public ShoppingList(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}