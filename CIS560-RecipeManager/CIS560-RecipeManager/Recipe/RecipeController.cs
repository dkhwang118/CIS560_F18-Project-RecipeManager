namespace CIS560_RecipeManager.RecipeManager
{
    public class RecipeController
    {
        private IQuery QueryRepository;

        public RecipeController(IQuery query)
        {
            QueryRepository = query;
        }

        public void LaunchRecipeForm()
        {
            new uiRecipe().Show();
        }
    }
}
