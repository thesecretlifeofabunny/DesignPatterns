using DesignPatterns.BehavioralPatterns.Mediator;

namespace xUnitTests.BehavioralPatterns;

/// <summary>
/// Learnt from
/// [1]Derek Banas, “Mediator Design Pattern,” YouTube, Oct. 29, 2012.
/// https://www.youtube.com/watch?v=8DxIpdKd41A (accessed Aug. 28, 2025).
/// </summary>
public class MediatorTests
{
    [Fact]
    public void ChildrensToyTradeMediator_MediateOffers_ChildNonExistentTradeDoesntGetNewToy()
    {
        // Arrange
        ChildrensToyTradeMediator childrenToyMediator = new();
        Child childOne = new("Billy", childrenToyMediator);
        Child childTwo = new("Kaley", childrenToyMediator);

        ChildrensToy toyOne = new("Beyblade");
        ChildrensToy toyTwo = new("Bionicle");
        ChildrensToy toyThree = new("Bingo Plushee");
        ChildrensToy toyFour = new("Pokemon Card");

        childOne.AddToyToOwnedToys(toyOne);
        childOne.AddToyToOwnedToys(toyTwo);
        childTwo.AddToyToOwnedToys(toyThree);
        childTwo.AddToyToOwnedToys(toyFour);

        // Act
        childrenToyMediator.OfferToy(childOne, toyOne);
        childrenToyMediator.AcceptToyOffer(childTwo, toyThree);

        // Assert

        Assert.NotNull(childTwo.OwnedToys);
        Assert.DoesNotContain(toyOne, childTwo.OwnedToys.AsEnumerable());
    }

    [Fact]
    public void ChildrensToyTradeMediator_MediateOffers_ChildAcceptingTradeGetsToyFromTrade()
    {
        // Arrange
        ChildrensToyTradeMediator childrenToyMediator = new();
        Child childOne = new("Billy", childrenToyMediator);
        Child childTwo = new("Kaley", childrenToyMediator);

        ChildrensToy toyOne = new("Beyblade");
        ChildrensToy toyTwo = new("Bionicle");
        ChildrensToy toyThree = new("Bingo Plushee");
        ChildrensToy toyFour = new("Pokemon Card");

        childOne.AddToyToOwnedToys(toyOne);
        childOne.AddToyToOwnedToys(toyTwo);
        childTwo.AddToyToOwnedToys(toyThree);
        childTwo.AddToyToOwnedToys(toyFour);

        // Act
        childrenToyMediator.OfferToy(childOne, toyOne);
        childrenToyMediator.AcceptToyOffer(childTwo, toyOne);

        // Assert

        Assert.NotNull(childTwo.OwnedToys);
        Assert.Contains(toyOne, childTwo.OwnedToys.AsEnumerable());
    }
}