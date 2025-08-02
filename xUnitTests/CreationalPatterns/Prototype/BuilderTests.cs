using DesignPatterns.Classes.Ramen;
using DesignPatterns.CreationalPatterns.Builder;
using DesignPatterns.CreationalPatterns.Prototype;

namespace xUnitTests.CreationalPatterns.Builder;

public class PrototypeTests()
{
    [Fact]
    public void Prototype_AddBroth_AddsBrothSelectedThenPrototype()
    {
        RamenPrototype ramenToTest = new();
        const RamenBroth brothToAdd = RamenBroth.Beef;
        
        RamenBuilder.AddBroth(ramenToTest, brothToAdd);
        var prototypeRamen = ramenToTest.CloneRamenBowl();
        
        Assert.True(prototypeRamen.RamenBroth is brothToAdd);
    }
    
    [Fact]
    public void Prototype_AddBroth_AddsNoodleSelectedThenPrototype()
    {
        RamenPrototype ramenToTest = new();
        const RamenNoodle noodleToAdd = RamenNoodle.Soba;
        
        RamenBuilder.AddNoodle(ramenToTest, noodleToAdd);
        var prototypeRamen = ramenToTest.CloneRamenBowl();
        
        Assert.True(prototypeRamen.RamenNoodle is noodleToAdd);
    }
    
    [Fact]
    public void Prototype_AddBroth_AddedIngredientIsNotNullAfterPrototyping()
    {
        RamenPrototype ramenToTest = new();
        const RamenIngredient ingredientToAdd = RamenIngredient.Bamboo;
        
        RamenBuilder.AddIngredient(ramenToTest, ingredientToAdd);
        var prototypeRamen = ramenToTest.CloneRamenBowl();
        
        Assert.NotNull(prototypeRamen.RamenIngredients);
    }
    
    [Fact]
    public void Prototype_AddBroth_AddsIngredientSelectedAfterPrototyping()
    {
        RamenPrototype ramenToTest = new();
        const RamenIngredient ingredientToAdd = RamenIngredient.Bamboo;
        
        RamenBuilder.AddIngredient(ramenToTest, ingredientToAdd);
        var prototypeRamen = ramenToTest.CloneRamenBowl();
        
        Assert.NotNull(ramenToTest.RamenIngredients);
        Assert.True(prototypeRamen.RamenIngredients is [ingredientToAdd]);
    }
    
    [Fact]
    public void Prototype_AddBroth_AddsTwoIngredientsSelectedAfterPrototyping()
    {
        RamenPrototype ramenToTest = new();
        List<RamenIngredient> ingredientsToAdd =
        [
            RamenIngredient.Bamboo,
            RamenIngredient.Corn

        ];

        RamenBuilder.AddIngredients(ramenToTest, ingredientsToAdd);
        var prototypeRamen = ramenToTest.CloneRamenBowl();

        Assert.NotNull(prototypeRamen.RamenIngredients);
        Assert.True(CompareTwoRamenIngredientLists(prototypeRamen.RamenIngredients, ingredientsToAdd));
    }
    
    [Fact]
    public void Prototype_AddBroth_AddsFiveIngredientsSelectedAfterPrototyping()
    {
        RamenPrototype ramenToTest = new();
        List<RamenIngredient> ingredientsToAdd =
        [
            RamenIngredient.Bamboo,
            RamenIngredient.Corn,
            RamenIngredient.Bamboo,
            RamenIngredient.Egg,
            RamenIngredient.Shitake
        ];

        RamenBuilder.AddIngredients(ramenToTest, ingredientsToAdd);
        var prototypeRamen = ramenToTest.CloneRamenBowl();


        Assert.NotNull(prototypeRamen.RamenIngredients);
        Assert.True(CompareTwoRamenIngredientLists(prototypeRamen.RamenIngredients, ingredientsToAdd));
    }
    
    [Fact]
    public void Prototype_AddBroth_AddsSizIngredientsSelectedAsListAndOneIndividual()
    {
        RamenPrototype ramenToTest = new();
        List<RamenIngredient> ingredientsToAdd =
        [
            RamenIngredient.Bamboo,
            RamenIngredient.Corn,
            RamenIngredient.Bamboo,
            RamenIngredient.Egg,
            RamenIngredient.Shitake
        ];

        const RamenIngredient ingredientToAddIndividually = RamenIngredient.Naruto;

        RamenBuilder.AddIngredients(ramenToTest, ingredientsToAdd);
        RamenBuilder.AddIngredient(ramenToTest, ingredientToAddIndividually);
        var prototypeRamen = ramenToTest.CloneRamenBowl();

        ingredientsToAdd.Add(ingredientToAddIndividually);
        
        Assert.NotNull(prototypeRamen.RamenIngredients);
        Assert.True(CompareTwoRamenIngredientLists(prototypeRamen.RamenIngredients, ingredientsToAdd));
    }

    private static bool CompareTwoRamenIngredientLists(List<RamenIngredient> listOne, List<RamenIngredient> listTwo)
    {
        return listOne.All(listTwo.Remove);
    }
}