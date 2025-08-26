namespace DesignPatterns.Classes.Library;

public class PublicLibrary()
{
    public List<string> AvailableBooks { get; } = [];

    public void AddBookToAvailableBooks(string bookToAdd) => AvailableBooks.Add(bookToAdd);
}