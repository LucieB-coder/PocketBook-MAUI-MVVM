using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IUserLibraryManager
    {
        
        Task<IEnumerable<Lend>> GetBorrows();
        Task<IEnumerable<Lend>> GetLends();
        void AddBookToFavorites(Book book);
        Task<IEnumerable<Book>> GetFavorites();

    }
}
