using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_RecipeManager.RecipeManager
{
    public class RecipeIngredient
    {
        public int Id { get; }
        public string Name { get; }
        public string Unit { get; }
        public int Quantity { get; }

        public int PriceInCents { get; }

        public string FormattedPrice
        {
            get
            {
                return "$" + (PriceInCents * Quantity / 100).ToString("#.##");
            }
        }

        public RecipeIngredient(int id, string name, string unit, int quantity, int price)
        {
            Id = id;
            Name = name;
            Unit = unit;
            Quantity = quantity;
            PriceInCents = price;
        }
    }
}
