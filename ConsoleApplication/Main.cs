namespace ClassLibrary.BehavioralPatterns.Iterator;

using ClassLibrary.BehavioralPatterns.Iterator.Implementation;
using ClassLibrary.BehavioralPatterns.Iterator.Interface;

public class Client
{
    public static void Main(string[] args)
    {
        BookCollection library = new BookCollection();
        library.AddBook(new Book("The Hobbit", "J.R.R. Tolkien"));
        library.AddBook(new Book("Harry Potter", "J.K. Rowling"));
        library.AddBook(new Book("Clean Code", "Robert C. Martin"));

        IIterator<Book> iterator = library.CreateIterator();

        Console.WriteLine("Books in library:");
        while (iterator.SetNext()) { Book book = iterator.Handle(); Console.WriteLine($"- {book}"); }
    }
}