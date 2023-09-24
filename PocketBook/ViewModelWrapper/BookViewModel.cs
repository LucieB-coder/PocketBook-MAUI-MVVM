using System.Collections.Specialized;
using System.ComponentModel;
using Model;

namespace ViewModelWrapper
{
    // All the code in this file is included in all platforms.
    public class BookViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Book> GetAllBooks(ILibraryManager libMng)
        {
            return libMng.GetAllBooks();
        }

    }
}