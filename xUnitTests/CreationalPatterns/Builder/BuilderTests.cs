using DesignPatterns.Classes.Ramen;
using DesignPatterns.CreationalPatterns.Builder;

namespace xUnitTests.CreationalPatterns.Builder;

public class BuilderTests()
{
    [Fact]
    public void Builder_AddBroth_AddsBrothSelected()
    {
        Ramen ramenToTest = new();
        const RamenBroth brothToAdd = RamenBroth.Beef;
        
        RamenBuilder.AddBroth(ramenToTest, brothToAdd);
        
        Assert.True(ramenToTest.RamenBroth is brothToAdd);
    }
    
    [Fact]
    public void Builder_AddBroth_AddsNoodleSelected()
    {
        Ramen ramenToTest = new();
        const RamenNoodle noodleToAdd = RamenNoodle.Soba;
        
        RamenBuilder.AddNoodle(ramenToTest, noodleToAdd);
        
        Assert.True(ramenToTest.RamenNoodle is noodleToAdd);
    }
    
    [Fact]
    public void Builder_AddBroth_AddedIngredientIsNotNull()
    {
        Ramen ramenToTest = new();
        const RamenIngredient ingredientToAdd = RamenIngredient.Bamboo;
        
        RamenBuilder.AddIngredient(ramenToTest, ingredientToAdd);
        
        Assert.NotNull(ramenToTest.RamenIngredients);
    }
    
    [Fact]
    public void Builder_AddBroth_AddsIngredientSelected()
    {
        Ramen ramenToTest = new();
        const RamenIngredient ingredientToAdd = RamenIngredient.Bamboo;
        
        RamenBuilder.AddIngredient(ramenToTest, ingredientToAdd);
        
        Assert.NotNull(ramenToTest.RamenIngredients);
        Assert.True(ramenToTest.RamenIngredients is [ingredientToAdd]);
    }
    
    [Fact]
    public void Builder_AddBroth_AddsTwoIngredientsSelected()
    {
        Ramen ramenToTest = new();
        List<RamenIngredient> ingredientsToAdd =
        [
            RamenIngredient.Bamboo,
            RamenIngredient.Corn

        ];

        RamenBuilder.AddIngredients(ramenToTest, ingredientsToAdd);

        Assert.NotNull(ramenToTest.RamenIngredients);
        
        Assert.True(CompareTwoRamenIngredientLists(ramenToTest.RamenIngredients, ingredientsToAdd));
    }
    
    [Fact]
    public void Builder_AddBroth_AddsFiveIngredientsSelected()
    {
        Ramen ramenToTest = new();
        List<RamenIngredient> ingredientsToAdd =
        [
            RamenIngredient.Bamboo,
            RamenIngredient.Corn,
            RamenIngredient.Bamboo,
            RamenIngredient.Egg,
            RamenIngredient.Shitake
        ];

        RamenBuilder.AddIngredients(ramenToTest, ingredientsToAdd);

        Assert.NotNull(ramenToTest.RamenIngredients);
        Assert.True(CompareTwoRamenIngredientLists(ramenToTest.RamenIngredients, ingredientsToAdd));
    }
    
    [Fact]
    public void Builder_AddBroth_AddsSizIngredientsSelectedAsListAndOneIndividual()
    {
        Ramen ramenToTest = new();
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

        ingredientsToAdd.Add(ingredientToAddIndividually);
        
        Assert.NotNull(ramenToTest.RamenIngredients);
        Assert.True(CompareTwoRamenIngredientLists(ramenToTest.RamenIngredients, ingredientsToAdd));
    }

    private static bool CompareTwoRamenIngredientLists(List<RamenIngredient> listOne, List<RamenIngredient> listTwo)
    {
        foreach (var ingredientFromListOne in listOne)
        {
            if (listTwo.Count == 0 || !listTwo.Contains(ingredientFromListOne)) return false;

            listTwo.Remove(ingredientFromListOne);
        }
        return true;
    }
}