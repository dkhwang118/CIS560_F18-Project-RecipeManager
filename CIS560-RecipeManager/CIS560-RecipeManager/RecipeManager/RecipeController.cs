

namespace CIS560_RecipeManager.RecipeManager
{
    public class RecipeController
    {
        private IQuery QueryRepository;
        private RecipeInventory recipeInventory;

        public RecipeController(IQuery query, RecipeInventory recipeInventory)
        {
            QueryRepository = query;
        }

        public void LaunchRecipeForm()
        {
            new uiRecipe().Show();
        }
    }
}
