using LTP3._2C.Models;
using System.Collections.Generic;

namespace LTP3._2C.Repositorrys
{
    public interface IBookRepositorry
    {
        IEnumerable<Book> Lista();
        void Adiciona(Book book);
    }
}
