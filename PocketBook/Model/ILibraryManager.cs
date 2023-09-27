using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface ILibraryManager
    {
        Book GetBookById(int id);
        Author GetAuthorById(int id);
        IEnumerable<Book> GetAllBooks();
        IEnumerable<Book> GetBooksByAuthor(int authorId);
    }
}
