using CookieCookbook.Recipes;
using static CookieCookbook.Recipes.Recipe;



namespace CookieCookbook.App;

public class CookiesRecipesApp
{

    private readonly IRecipesRepository _recipesRepository;
    private readonly IRecipesUserInteraction _recipesUserInteraction;

    public CookiesRecipesApp(IRecipesRepository recipesRepository, IRecipesUserInteraction recipesUserInteraction)
    {
        _recipesRepository = recipesRepository;
        _recipesUserInteraction = recipesUserInteraction;
    }
    public void Run(string filePath)
    {
        var allrecipes = _recipesRepository.Read(filePath);
        _recipesUserInteraction.PrintExistingRecipes(allrecipes);
        _recipesUserInteraction.PromptToCreateRecipe();

        var ingredients = _recipesUserInteraction.ReadIngredientsFromUser();

        if (ingredients.Count() > 0)
        {
            var recipe = new Recipe(ingredients);
            allrecipes.Add(recipe);
            _recipesRepository.Write(filePath, allrecipes);
            _recipesUserInteraction.ShowMessage("recipes added: ");
            _recipesUserInteraction.ShowMessage(recipe.ToString());

        }
        else
        {
            _recipesUserInteraction.ShowMessage("no ingredients have been selected." + "recipe will not be saved.");
        }

        _recipesUserInteraction.Exit();

    }
}
