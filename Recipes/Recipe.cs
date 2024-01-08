using CookieCookbook.Recipes.Ingredients;

namespace CookieCookbook.Recipes;

public partial class Recipe
{

    public IEnumerable<Ingredient> Ingredients { get;  }

    public Recipe(IEnumerable<Ingredient> ingredients)
    {
        Ingredients = ingredients;
    }

    public override string ToString()
    {
        var steps = new List<string>();
        foreach(var ingredients in Ingredients)
        {
            steps.Add($"{ingredients.Name}. {ingredients.PreparationInstructions}.");
        }

        return string.Join( Environment.NewLine, steps); 
    }
}
