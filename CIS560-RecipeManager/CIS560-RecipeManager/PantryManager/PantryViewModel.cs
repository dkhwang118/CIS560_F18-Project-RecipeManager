﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_RecipeManager.PantryManager
{
    public class PantryViewModel
    {
        public BindingList<Ingredient> IngredientList { get; }

        public PantryViewModel(IDictionary<Ingredient, int> ingredients)
        {
            IngredientList = new BindingList<Ingredient>();
            foreach (var kvp in ingredients)
            {
                IngredientList.Add(kvp.Key);
            }
        }
    }
}
