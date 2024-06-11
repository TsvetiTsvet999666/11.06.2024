namespace Exersice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            library.AddBook(new Book("Moonlight", "George Marinov", "Helicon", 2001, 1));
            library.AddBook(new Book("Sunshine", "Ani Makova", "Ciela", 2005, 2));
            library.AddBook(new Book("One Sunday", "Kasi D", "Orange Center", 1999, 3));
            library.DisplayAllBooks();
            Console.WriteLine("Display book by title 'Moonlight':");
            library.DisplayBookByTitle("Moonlight");
            Console.WriteLine("Display books by author 'George Marinov':");
            library.DisplayBooksByAuthor("George Marinov");
            Console.WriteLine("Updating book with title 'Moonlight':");
            library.UpdateBookByTitle("Book A", new Book("Moonlight Updated", "George Marinov", "Helion A Updated", 2021, 1));
            library.DisplayAllBooks();
            Console.WriteLine("Deleting book with title 'Sunshine':");
            library.DeleteBookByTitle("Sunshine");
            library.DisplayAllBooks(); 
            Console.WriteLine("Average age of books:");
            Console.WriteLine(library.CalculateAverageAge());
            Console.WriteLine("Oldest book in the library:");
            library.DisplayOldestBook();
            Console.WriteLine("Newest book by author 'George Marinov':");
            library.DisplayNewestBookByAuthor("George Marinov");
            Console.WriteLine("Sorting books by author and catalog number:");
            library.SortBooks();
            library.DisplayAllBooks();
        }
    }
}
