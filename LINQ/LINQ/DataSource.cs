using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    public class DataSource
    {
        public static List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book {BookId = 1, BookName = "The Old Man and The Sea", Price = 100, AuthorName = "Ernest", Category = "Language", Rating = 4},
                new Book {BookId = 2, BookName = "Animal Farm", Price = 90, AuthorName ="George Orwell", Category = "Language", Rating = 4},
                new Book {BookId = 3, BookName = "Intro to Programming", Price = 85, AuthorName="Albert", Category = "Programming", Rating = 5},
                new Book {BookId = 4, BookName = "Ancient Egypt", Price = 110, AuthorName = "Barry J. Kemp", Category = "Civilisation", Rating = 3},
                new Book {BookId = 5, BookName = "A Little Life", Price = 150, AuthorName = "Hanya", Category = "Life", Rating = 4},

            };
        }
    }
}
