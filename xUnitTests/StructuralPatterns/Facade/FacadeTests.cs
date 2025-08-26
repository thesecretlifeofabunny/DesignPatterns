using DesignPatterns.Classes.Botanical;
using DesignPatterns.StructuralPatterns.Facade;

namespace xUnitTests.StructuralPatterns.Facade;

public class FacadeTests
{
    [Fact]
    public void WaterPlantFacade_WaterThePlant_NotWateredPlantShouldBeWatered()
    {
        Habitat tijuana = new("tijuana", false);
        Plant laelia = new("Laelia Orchid", false, tijuana);
        
        WaterPlantFacade.WaterThePlant(laelia);
        
        Assert.True(laelia.HasBeenWateredWithinAWeek);
    }
    
    [Fact]
    public void WaterPlantFacade_WaterThePlant_WateredPlantShouldNotBeWatered()
    {
        Habitat tijuana = new("tijuana", false);
        Plant laelia = new("Laelia Orchid", true, tijuana);
        
        WaterPlantFacade.WaterThePlant(laelia);
        
        Assert.True(laelia.HasBeenWateredWithinAWeek);
    }
    
    [Fact]
    public void WaterPlantFacade_WaterThePlant_WateredPlantFromHabitatShouldNotBeWatered()
    {
        Habitat tijuana = new("tijuana", true);
        Plant laelia = new("Laelia Orchid", false, tijuana);
        
        WaterPlantFacade.WaterThePlant(laelia);
        
        Assert.True(laelia.HasBeenWateredWithinAWeek);
    }

}