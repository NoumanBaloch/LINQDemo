using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = DataSource.GetBooks();

            //var filteredBooks = books.Where(x => x.Rating > 2).OrderBy(x => x.BookName);

            //var filteredBooks = books.OrderByDescending(x => x.BookName);


            //var singleBook = books.SingleOrDefault(x => x.BookName == "Animal Farms");

            //var singleBook = books.FirstOrDefault(x => x.BookName == "Animal Farms");

            //var filteredBooks = books.Skip(2).Take(3);

            //int result = books.Count();

            //Console.WriteLine(result);

            var count = books.Sum(x => x.Price);

            Console.WriteLine(count);
            //foreach(var book in books)
            //{
            //    if(book.Rating > 3)
            //    {
            //        Console.WriteLine("Book Name = " + book.BookName + "\n" + "Author Name = " + book.AuthorName + "\n" +
            //            "Book Rating = " + book.Rating + "\n" + "Price = " + book.Price );

            //        Console.WriteLine("---------------------------------------------------");
            //    }
            //}

            
            Console.WriteLine("\n\n------------Seperator------------\n\n");

            //if(singleBook != null)
            //{
            //    Console.WriteLine("Book Name = " + singleBook.BookName + "\n" + "Author Name = " + singleBook.AuthorName + "\n" +
            //          "Book Rating = " + singleBook.Rating + "\n" + "Price = " + singleBook.Price);
            //}


            //foreach (var book in filteredBooks)
            //{
            //    Console.WriteLine("Book Name = " + book.BookName + "\n" + "Author Name = " + book.AuthorName + "\n" +
            //            "Book Rating = " + book.Rating + "\n" + "Price = " + book.Price);
            //    Console.WriteLine("---------------------------------------------------");
            //}

            Console.ReadKey();
        }
    }
}
