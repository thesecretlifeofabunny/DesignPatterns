using DesignPatterns.Classes.Ramen;

namespace DesignPatterns.CreationalPatterns.Builder;

public class RamenBuilder : IRamenBuilder
{
    public static void AddBroth(Ramen ramenBowl, RamenBroth brothToAdd)
        => ramenBowl.RamenBroth = brothToAdd;

    public static void AddNoodle(Ramen ramenBowl, RamenNoodle noodleToAdd)
        => ramenBowl.RamenNoodle = noodleToAdd;

    public static void AddIngredient(Ramen ramenBowl, RamenIngredient ingredientToAdd)
        => ramenBowl.AddIngredient(ingredientToAdd);

    public static void AddIngredients(Ramen ramenBowl, List<RamenIngredient> ingredientsToAdd)
    {
        foreach (var ingredientToAdd in ingredientsToAdd)
        {
            ramenBowl.AddIngredient(ingredientToAdd);
        }
    }
}