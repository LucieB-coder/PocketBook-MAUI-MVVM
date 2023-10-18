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

        public IEnumerable<Book> Books { get; set; }
        private List<Book> books = new();

        #endregion

        #region Methods

        public Task<Book> GetBookById(int id)
            => libraryManager.GetBookById(id);

        public Author GetAuthorById(int id)
            => libraryManager.GetAuthorById(id);

        public Task<IEnumerable<Book>> GetAllBooks()
        {
            return libraryManager.GetAllBooks();
        }
       
        public IEnumerable<Book> GetBooksByAuthor(int authorId)
            => libraryManager.GetBooksByAuthor(authorId);

        #endregion

        #region Constructor

        public Manager(ILibraryManager libraryManager)
        {
            this.libraryManager = libraryManager;
            Books = new ReadOnlyCollection<Book>(books);
        }

        #endregion
    }
}
