using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Manager
    {
        #region Fields

        private ILibraryManager libraryManager { get; set; }
        private IUserLibraryManager userLibraryManager { get; set; }

        public IEnumerable<Book> Books { get; set; }
        private List<Book> books = new();

        #endregion

        #region Methods

        public Task<Book> GetBookById(int id)
            => libraryManager.GetBookById(id);


        public Task<IEnumerable<Book>> GetAllBooks()
        {
            return libraryManager.GetAllBooks();
        }

        public Task<IEnumerable<Lend>> GetLends()
            => userLibraryManager.GetLends();

        public Task<IEnumerable<Lend>> GetBorrows()
            => userLibraryManager.GetBorrows();

        public void AddBookToFavorites(Book book)
            =>userLibraryManager.AddBookToFavorites(book);

        public Task<IEnumerable<Book>> GetFavorites()
            => userLibraryManager.GetFavorites();

        #endregion

        #region Constructor

        public Manager(ILibraryManager libraryManager, IUserLibraryManager userLibraryManager)
        {
            this.libraryManager = libraryManager;
            this.userLibraryManager = userLibraryManager;
            Books = new ReadOnlyCollection<Book>(books);
        }

        #endregion
    }
}
