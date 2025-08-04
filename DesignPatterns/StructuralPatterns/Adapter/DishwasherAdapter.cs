using DesignPatterns.Classes.Appliances;

namespace DesignPatterns.StructuralPatterns.Adapter;

// Not perfect interface, but the concept is what matters for me in this learning.
public class DishwasherAdapter(ClothesWasher clothesWasher) : IDishwasher
{
    private ClothesWasher ClothesWasherToAdapt { get; } = clothesWasher;

    public string PutTheDishesIn() => ClothesWasherToAdapt.PutTheClothesIn();

    public string StartTheDishwasher() => ClothesWasherToAdapt.TurnTheClothesWasherOn();

    public string TakeTheDishesOut() => ClothesWasherToAdapt.TakeTheClothesOut();
}