namespace DesignPatterns.Classes.Ramen;

public class Ramen : IRamen
{
    public RamenBroth RamenBroth { get; set; }
    public RamenNoodle RamenNoodle { get; set; }
    public List<RamenIngredient>? RamenIngredients { get; set; }

    public void AddIngredient(RamenIngredient ingredientToAdd)
    {
        RamenIngredients ??= [];
        RamenIngredients.Add(ingredientToAdd);
    }
}