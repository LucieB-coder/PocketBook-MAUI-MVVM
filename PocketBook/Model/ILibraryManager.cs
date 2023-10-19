using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ILibraryManager
    {
        Task<Book> GetBookById(int id);
        Task<IEnumerable<Book>> GetAllBooks();
    }
}
