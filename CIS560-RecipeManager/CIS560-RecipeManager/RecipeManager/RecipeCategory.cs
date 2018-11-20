namespace CIS560_RecipeManager.RecipeManager
{
    public class RecipeCategory
    {
        public int Id { get; }
        public string Name { get; }

        public RecipeCategory(int id, string name)
        {
            Id = id;
            Name = name;
        }

        override public string ToString()
        {
            return Name;
        }
    }
}