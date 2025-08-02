using DesignPatterns.Classes.Ramen;

namespace DesignPatterns.CreationalPatterns.Builder;

public interface IRamenBuilder
{
    public static abstract void AddBroth(Ramen ramenBowl, RamenBroth brothToAdd);

    public static abstract void AddNoodle(Ramen ramenBowl, RamenNoodle noodleToAdd);

    public static abstract void AddIngredient(Ramen ramenBowl, RamenIngredient ingredientToAdd);

    public static abstract void AddIngredients(Ramen ramenBowl, List<RamenIngredient> ingredientsToAdd);
}