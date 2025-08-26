using DesignPatterns.Classes.Library;

namespace DesignPatterns.StructuralPatterns.Proxy;

public class SchoolLibraryProxy()
{
    private List<string> BannedBooks { get; } = ["Moby Dick", "Bluey", "Elmo"];
    private readonly PublicLibrary _theSchoolsLibrary  = new();

    public void AddBookToLibrary(string bookToAdd)
    {
        if (!BannedBooks.Contains(bookToAdd))
            _theSchoolsLibrary.AddBookToAvailableBooks(bookToAdd);
    }

    public bool IsBookAvailable(string bookToCheck) => _theSchoolsLibrary.AvailableBooks.Contains(bookToCheck);
}