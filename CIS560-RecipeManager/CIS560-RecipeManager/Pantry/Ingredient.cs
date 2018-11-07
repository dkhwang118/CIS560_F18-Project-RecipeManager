namespace CIS560_RecipeManager
{
    public class Ingredient
    {
        public int Id { get; }

        public string Name { get; }

        public int PantryQuantity { get; set; }

        public string Unit { get; }

        public Ingredient(int id, string name, string unit)
        {
            Id = id;
            Name = name;
            Unit = unit;
        }
    }
}