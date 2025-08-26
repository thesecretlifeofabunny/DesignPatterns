using DesignPatterns.StructuralPatterns.Proxy;

namespace xUnitTests.StructuralPatterns.Proxy;

public class ProxyTests
{
    [Fact]
    public void SchoolLibraryProxy_AddBookToLibrary_NoBookAreAvailableAtCreation()
    {
        // Arrange
        SchoolLibraryProxy schoolLibrary = new();
        
        // Act
        var isBookAvailable = schoolLibrary.IsBookAvailable("test");
        
        // Assert
        Assert.False(isBookAvailable);
    }
    
    [Fact]
    public void SchoolLibraryProxy_AddBookToLibrary_CanAddNonBannedBook()
    {
        // Arrange
        SchoolLibraryProxy schoolLibrary = new();
        
        // Act
        schoolLibrary.AddBookToLibrary("Meow chronicles");
        var isBookAvailable = schoolLibrary.IsBookAvailable("Meow chronicles");
        
        // Assert
        Assert.True(isBookAvailable);
    }
    
    [Fact]
    public void SchoolLibraryProxy_AddBookToLibrary_CantAddBannedBook()
    {
        // Arrange
        SchoolLibraryProxy schoolLibrary = new();
        
        // Act
        schoolLibrary.AddBookToLibrary("Bluey");
        var isBookAvailable = schoolLibrary.IsBookAvailable("Bluey");
        
        // Assert
        Assert.False(isBookAvailable);
    }
}