using System;
using System.Collections.Generic;
using System.Linq;
using Library.Data;
using Library.Data.Models;

namespace Library.Service
{
    public class BookService : IBookService
    {
        public IEnumerable<Book> GetAllBooks()
        {
            return BooksTable();
        }

        public Book GetBook(Func<Book, bool> search)
        {
            IEnumerable<Book> Books = GetAllBooks();
            foreach(Book book in Books)
            {
                if(search(book)) return book;
            }
            return null;
        }

        private static Book[] BooksTable()
        {
            Author author = new Author() {
                Id = 1,
                Name = "Ryan Graute"
            };
            Book book1 = new Book() {
                Id = 1,
                Name = "The Adventures of Mikey",
                Author = author
                
            };
            Book book2 = new Book() {
                Id = 2,
                Name = "The Adventures of Tommy",
                Author = author
            };

            return new Book[2] {book1, book2};

        }
    }
}
