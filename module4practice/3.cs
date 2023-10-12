using System;
class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
}

class HomeLibrary
{
    private List<Book> library = new List<Book>();

    public void AddBook(Book book)
    {
        library.Add(book);
    }
    public void RemoveBook(Book book)
    {
        library.Remove(book);
    }
    public List<Book> GetBooksByAuthor(string author)
    {
        return library.Where(book => book.Author == author).ToList();
    }
    public List<Book> GetBooksByYear(int year)
    {
        return library.Where(book => book.Year == year).ToList();
    }
    public void SortBooksByTitle()
    {
        library.Sort((book1, book2) => book1.Title.CompareTo(book2.Title));
    }
    public void SortBooksByAuthor()
    {
        library.Sort((book1, book2) => book1.Author.CompareTo(book2.Author));
    }
     public void SortBooksByYear()
    {
        library.Sort((book1, book2) => book1.Year.CompareTo(book2.Year));
    }
}
