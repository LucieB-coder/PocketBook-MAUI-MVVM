using System.Collections.Specialized;
using System.ComponentModel;
using Model;

namespace ViewModelWrapper
{
    // All the code in this file is included in all platforms.
    public class BookViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private ILibraryManager libraryManager;
        public IEnumerable<Book> GetAllBooks()
        {
            return libraryManager.GetAllBooks();
        }
        public IEnumerable<Book> GetBooksByAuthor(int authorId)
        {
            return libraryManager.GetBooksByAuthor(authorId);
        }
        public BookViewModel(ILibraryManager libraryManager)
        {
            this.libraryManager = libraryManager;
        }
    }
}