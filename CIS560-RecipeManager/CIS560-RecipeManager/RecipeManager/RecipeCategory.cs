using System;

namespace CIS560_RecipeManager.RecipeManager
{
    public class RecipeCategory : IEquatable<RecipeCategory>
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

        public bool Equals(RecipeCategory other)
        {
            return other.Id == this.Id;
        }

        public static bool operator ==(RecipeCategory cat1, RecipeCategory cat2)
        {
            return cat1.Equals(cat2);
        }

        public static bool operator !=(RecipeCategory cat1, RecipeCategory cat2)
        {
            return !cat1.Equals(cat2);
        }

        public override bool Equals(object obj)
        {
            return obj.GetType() == GetType() && Equals((RecipeCategory)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Id.GetHashCode();
                hashCode = (hashCode * 397) ^ Name.GetHashCode();
                return hashCode;
            }
        }
    }
}