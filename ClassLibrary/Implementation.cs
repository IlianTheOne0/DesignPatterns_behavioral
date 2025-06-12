namespace ClassLibrary.BehavioralPatterns.Iterator.Implementation;

using ClassLibrary.BehavioralPatterns.Iterator.Interface;

public class Book
{
    public string Title { get; }
    public string Author { get; }

    public Book(string Title, string Author) { this.Title = Title; this.Author = Author; }

    public override string ToString() => $"{Title} by {Author}";
}

public class BookCollection : IAggregate<Book>
{
    private readonly List<Book> _books = new();

    public void AddBook(Book book) => _books.Add(book);
    public void RemoveBook(Book book) => _books.Remove(book);
    public int Count => _books.Count;
    public IIterator<Book> CreateIterator() => new BookIterator(this);

    private class BookIterator : IIterator<Book>
    {
        private readonly BookCollection _collection;
        private int _index = 0;

        public BookIterator(BookCollection collection) => _collection = collection;

        public bool SetNext() => _index < _collection.Count;
        public Book Handle()
        {
            if (!SetNext()) { throw new InvalidOperationException("No more books in collection"); }
            return _collection._books[_index++];
        }
    }
}