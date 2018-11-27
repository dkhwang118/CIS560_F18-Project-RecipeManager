using System;
using System.Collections.Generic;

namespace CIS560_RecipeManager.Repository
{
    public partial class Query : IQuery
    {
        public ICollection<Ingredient> GetAllIngredients()
        {
            throw new NotImplementedException();
        }
    }
}
