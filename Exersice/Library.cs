using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice
{
    internal class Library
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public void DisplayAllBooks()
        {
            Console.WriteLine($"{"Title",-30} {"Author",-20} {"Publisher",-20} {"Year",-10} {"Catalog Number",-10}");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
        public void DisplayBookByTitle(string title)
        {
            var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                Console.WriteLine(book);
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
        public void DisplayBooksByAuthor(string author)
        {
            var authorBooks = books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
            if (authorBooks.Any())
            {
                foreach (var book in authorBooks)
                {
                    Console.WriteLine(book);
                }
            }
            else
            {
                Console.WriteLine("No books found by this author.");
            }
        }
        public void UpdateBookByTitle(string title, Book newBookData)
        {
            var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                book.Title = newBookData.Title;
                book.Author = newBookData.Author;
                book.Publisher = newBookData.Publisher;
                book.Year = newBookData.Year;
                book.CatalogNumber = newBookData.CatalogNumber;
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
        public void DeleteBookByTitle(string title)
        {
            var book = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                books.Remove(book);
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
        public double CalculateAverageAge()
        {
            if (books.Any())
            {
                double averageYear = books.Average(b => b.Year);
                return DateTime.Now.Year - averageYear;
            }
            return 0;
        }
        public void DisplayOldestBook()
        {
            if (books.Any())
            {
                var oldestBook = books.OrderBy(b => b.Year).First();
                Console.WriteLine(oldestBook);
            }
            else
            {
                Console.WriteLine("No books in the library.");
            }
        }
        public void DisplayNewestBookByAuthor(string author)
        {
            var authorBooks = books.Where(b => b.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();
            if (authorBooks.Any())
            {
                var newestBook = authorBooks.OrderByDescending(b => b.Year).First();
                Console.WriteLine(newestBook);
            }
            else
            {
                Console.WriteLine("No books found by this author.");
            }
        }
        public void SortBooks()
        {
            books = books.OrderBy(b => b.Author).ThenBy(b => b.CatalogNumber).ToList();
        }
    }
}
