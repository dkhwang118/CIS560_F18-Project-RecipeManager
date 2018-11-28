using System;

namespace CIS560_RecipeManager
{
    public class Ingredient : IEquatable<Ingredient>
    {
        public int Id { get; }

        public string Name { get; }

        public string Unit { get; }

        public int Price { get; }

        public Ingredient(int id, string name, string unit, int price)
        {
            Id = id;
            Name = name;
            Unit = unit;
            Price = price;
        }

        public override string ToString()
        {
            return $"Ingredient(id: {Id}, name: {Name}, unit: {Unit})";
        }

        public bool Equals(Ingredient other)
        {
            return other.Id == this.Id;
        }

        public static bool operator ==(Ingredient ing1, Ingredient ing2)
        {
            return ing1.Equals(ing2);
        }

        public static bool operator !=(Ingredient ing1, Ingredient ing2)
        {
            return !ing1.Equals(ing2);
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == GetType() && Equals((Ingredient)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Id.GetHashCode();
                hashCode = (hashCode * 397) ^ Name.GetHashCode();
                hashCode = (hashCode * 397) ^ Unit.GetHashCode();
                return hashCode;
            }
        }
    }
}