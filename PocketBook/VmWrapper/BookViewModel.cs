using Model;
using System.Collections.Specialized;
using System.Windows.Input;

namespace VmWrapper
{
    public class BookViewModel : INotifyCollectionChanged
    {
        public event NotifyCollectionChangedEventHandler? CollectionChanged;

        public ICommand GetAllBooksCommand { get; set; }

        public BookViewModel() 
        {
            GetAllBooksCommand = new Command(GetAllBooks);
        }

        private List<Book> GetAllBooks()
        {
            return new List<Book>();
        }
    }
}