using System;
using System.Collections.Generic;
using Library.Data.Models;

namespace Library.Data
{
    public interface IBookService
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBook(Func<Book, bool> search);
    }
}
