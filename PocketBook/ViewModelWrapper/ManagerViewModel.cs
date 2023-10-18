using Model;
using MyToolkit;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelWrapper
{
    public class ManagerViewModel : BaseViewModelWrapper<ManagerViewModel>
    {
        public Manager Model { get; set; }

        public ObservableCollection<BookViewModel> Books { get; set; } = new ObservableCollection<BookViewModel>();
        public BookViewModel BookVM { get; set; } = new BookViewModel();

        public async void GetAllBooks()
        {
            var books = await Model.GetAllBooks();
            Books.Clear();
            foreach(var book in books)
            {
                Books.Add(new BookViewModel(book));
            }
        }

        public async void GetBookById(int id)
        {
            var book = await  Model.GetBookById(id);
            BookVM = new BookViewModel(book);
        }

        public ManagerViewModel(ILibraryManager libMng)
        {
            Model = new Manager(libMng);
        }

    }
}
