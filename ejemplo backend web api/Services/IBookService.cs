using ejercicio_LU.Model;
using System.Collections.Generic;
using System.Linq;

namespace ejercicio_LU.Services
{
    public interface IBookService
    {
        List<Book> GetAll();
        Book Get(int id);
        void Save(Book book);
        void Delete(int id);
    }
}