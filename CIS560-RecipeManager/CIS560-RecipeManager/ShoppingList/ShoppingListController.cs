using CIS560_RecipeManager.RecipeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS560_RecipeManager.ShoppingListManager
{
    public class ShoppingListController
    {
        private IQuery _queryRepository;
        private Pantry _pantry;
        private RecipeInventory _recipeRepository;
        
        public ShoppingListController(
            IQuery query,
            Pantry pantry,
            RecipeInventory recipeRepository)
        {
            _queryRepository = query;
            _pantry = pantry;
            _recipeRepository = recipeRepository;
        }

        public void LaunchShoppingListForm()
        {
            //not implemented yet
        }
    }
}
