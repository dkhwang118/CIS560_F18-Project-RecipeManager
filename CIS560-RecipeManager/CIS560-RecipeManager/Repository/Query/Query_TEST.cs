/*
 * Query_TEST.cs
 * partial Query class used for testing individual IQuery methods. Meant only to prevent errors upon compilation
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIS560_RecipeManager.RecipeManager;

namespace CIS560_RecipeManager.Repository
{
    public partial class Query : IQuery
    {

        public ShoppingList GetShoppingList(ICollection<Recipe> recipes)
        {
            // not implemented
            throw new NotImplementedException();
        }

    }
}
