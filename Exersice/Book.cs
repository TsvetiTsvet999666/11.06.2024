using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public int CatalogNumber { get; set; }
        public Book(string title, string author, string publisher, int year, int catalogNumber)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            Year = year;
            CatalogNumber = catalogNumber;
        }
        public override string ToString()
        {
            return $"{Title,-30} {Author,-20} {Publisher,-20} {Year,-10} {CatalogNumber,-10}";
        }
    }
}
