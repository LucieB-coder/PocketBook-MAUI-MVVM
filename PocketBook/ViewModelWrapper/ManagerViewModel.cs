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

        public ObservableCollection<BookGroupViewModel> Books { get; set; } = new ObservableCollection<BookGroupViewModel>();
        public BookViewModel BookVM { get; set; } = new BookViewModel();
        public async void GetAllBooks()
        {
            var books = await Model.GetAllBooks();
            IEnumerable<string> authors = books.Select(book => book.Author).Distinct();
            Books.Clear();
            foreach(var author in authors)
            {
                var bookList = books.Where(book => book.Author.Equals(author));
                List<BookViewModel> booksViewModel = new List<BookViewModel>();
                foreach(var book in bookList)
                {
                    booksViewModel.Add(new BookViewModel(book));
                }
                Books.Add(new BookGroupViewModel(author,booksViewModel));
            }
        }

        public async void GetBookById(int id)
        {
            var book = await Model.GetBookById(id);
            var bookViewModel = new BookViewModel(book);
            if(bookViewModel.Id != BookVM.Id)
            {
                BookVM.Id = bookViewModel.Id;
                BookVM.Title = bookViewModel.Title;
                BookVM.Author = bookViewModel.Author;
                BookVM.CoverImage = bookViewModel.CoverImage;
                BookVM.ReadingStatus = bookViewModel.ReadingStatus;
                BookVM.Grade = bookViewModel.Grade;
            }
        }

        public void ReverseList()
        {
            var reversedList=Books.Reverse().ToList();
            Books.Clear();
            foreach (var bookgroup in reversedList)
            {
                Books.Add(bookgroup);
            }
        }

        public ManagerViewModel(ILibraryManager libMng)
        {
            Model = new Manager(libMng);
        }

    }
}
