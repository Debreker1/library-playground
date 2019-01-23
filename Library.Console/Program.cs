using System;
using System.Collections.Generic;
using Library.Data;
using Library.Data.Models;
using Library.Service;
using System.Linq;

namespace Library.Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            BookService service = new BookService();
            BookController controller = new BookController(service);
            
            controller.GetBookById(1);
        }
    }

    public class BookController
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService) => _bookService = bookService;

        public void DisplayAllBooks()
        {
            IEnumerable<Book> allBooks = _bookService.GetAllBooks();

            foreach (Book book in allBooks)
            {
                System.Console.WriteLine(book.Name);
            }
        }

        private Book GetBookBy(Func<Book, bool> condition)
        {
            Book book = _bookService.GetBook(condition);
            return book;
        }

        public void GetBookById(int id)
        {
            Book book = GetBookBy(x => x.Id == id);
            System.Console.WriteLine(book.Name);
        }
    }
}
