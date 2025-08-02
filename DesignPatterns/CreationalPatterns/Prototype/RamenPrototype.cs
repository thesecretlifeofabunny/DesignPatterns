using DesignPatterns.Classes.Ramen;

namespace DesignPatterns.CreationalPatterns.Prototype;

public class RamenPrototype : Ramen
{
    public Ramen CloneRamenBowl()
    {
        return new Ramen
        {
            RamenBroth = RamenBroth,
            RamenNoodle = RamenNoodle,
            RamenIngredients = RamenIngredients
        };
    }
}