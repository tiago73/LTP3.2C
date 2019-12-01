using System.Collections.Generic;
using LTP3._2C.Models;

namespace LTP3._2C.Repositorrys
{
    public class MockBookRepositorry : IBookRepositorry
    {
        private static List<Book> _books = new List<Book>();
        public void Adiciona(Book book)
        {
            _books.Add(book);
        }

        public IEnumerable<Book> Lista()
        {
            return _books;
        }
    }
}
