namespace CookieCookbook.Recipes.Ingredients;

public abstract class Spiece : Ingredient
{
    public override string PreparationInstructions => $"Take half a teaspoon.{base.PreparationInstructions}";
}
