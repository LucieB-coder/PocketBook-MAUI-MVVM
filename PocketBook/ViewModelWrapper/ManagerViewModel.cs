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
        public int Filter { get; set; } 
        public ObservableCollection<FilterItemViewModel> FilteredItemList { get; set; } = new ObservableCollection<FilterItemViewModel>();
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
                BookVM.Description = bookViewModel.Description;
                BookVM.CoverImage = bookViewModel.CoverImage;
                BookVM.ReadingStatus = bookViewModel.ReadingStatus;
                BookVM.Grade = bookViewModel.Grade;
                BookVM.AddedOnLibraryDate = bookViewModel.AddedOnLibraryDate;
                BookVM.NumberOfPages = bookViewModel.NumberOfPages;
                BookVM.ISBN = bookViewModel.ISBN;
                BookVM.PublishingHouse = bookViewModel.PublishingHouse;
                BookVM.ParutionYear = bookViewModel.ParutionYear;
            }
        }

        public void ReverseList(string list)
        {
            switch (list)
            {
                case "books":
                    var reversedBooksList = Books.Reverse().ToList();
                    Books.Clear();
                    foreach (var bookgroup in reversedBooksList)
                    {
                        Books.Add(bookgroup);
                    }
                    break;
                case "filters":
                    var reversedFiltersList = FilteredItemList.Reverse().ToList();
                    FilteredItemList.Clear();
                    foreach (var filterItem in reversedFiltersList)
                    {
                        FilteredItemList.Add(filterItem);
                    }
                    break;

            }
            
        }

        public async void GetAuthorsList()
        {
            Filter= 1;
            var books = await Model.GetAllBooks();
            IEnumerable<string> authors = books.Select(book => book.Author).Distinct();
            FilteredItemList.Clear();
            foreach(var author in authors)
            {
                int countBooks = books.Count(book => book.Author == author);
                FilteredItemList.Add(new FilterItemViewModel(author,countBooks.ToString()));
            }
        }

        public async void GetGradesList()
        {
            Filter = 3;
            var books = await Model.GetAllBooks();
            IEnumerable<int> grades = books.Select(book => book.Grade).Distinct();
            FilteredItemList.Clear();
            foreach(var grade in grades)
            {
                int countBooks = books.Count(book => book.Grade == grade);
                FilteredItemList.Add(new FilterItemViewModel(grade.ToString(), countBooks.ToString()));
            }
        }

        public async void GetDatesList()
        {
            Filter = 2;
            var books = await Model.GetAllBooks();
            IEnumerable<int> dates = books.Select(book => book.ParutionYear).Distinct();
            FilteredItemList.Clear();
            foreach (var date in dates)
            {
                int countBooks = books.Count(book => book.ParutionYear == date);
                FilteredItemList.Add(new FilterItemViewModel(date.ToString(), countBooks.ToString()));
            }
        }

        public ManagerViewModel(ILibraryManager libMng)
        {
            Model = new Manager(libMng);
        }

    }
}
