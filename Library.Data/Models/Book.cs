using System;

namespace Library.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
    }
}
