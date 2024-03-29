﻿using Model;
using MyToolkit;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ViewModelWrapper
{
    public class ManagerViewModel : BaseViewModelWrapper<ManagerViewModel>
    {
        public Manager Model { get; set; }
        public int Filter { get; set; } 
        public ObservableCollection<FilterItemViewModel> FilteredItemList { get; set; } = new ObservableCollection<FilterItemViewModel>();
        public ObservableCollection<BookGroupViewModel> Books { get; set; } = new ObservableCollection<BookGroupViewModel>();
        public BookViewModel BookVM { get; set; } = new BookViewModel();
        public ICommand ReverseListCommand { get; set; }
        public ICommand GetLendsCommand { get; set; }
        public ICommand GetBorrowsCommand { get; set; }

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

        public async void GetLends()
        {
            var lends = await Model.GetLends();
            Books.Clear();
            foreach(var lend in lends)
            {
                List<BookViewModel> booksViewModel = new List<BookViewModel>();
                foreach (var bookId in lend.BookIdsBorrowed)
                {
                    var book = await Model.GetBookById(bookId);
                    booksViewModel.Add(new BookViewModel(book));
                }
                Books.Add(new BookGroupViewModel(lend.PersonName, booksViewModel));
            }
        }
        public async void GetBorrows()
        {
            var lends = await Model.GetBorrows();
            Books.Clear();
            foreach (var lend in lends)
            {
                List<BookViewModel> booksViewModel = new List<BookViewModel>();
                foreach (var bookId in lend.BookIdsBorrowed)
                {
                    booksViewModel.Add(new BookViewModel(await Model.GetBookById(bookId)));
                }
                Books.Add(new BookGroupViewModel(lend.PersonName, booksViewModel));
            }
        }
        public async void GetBooksByGrade(string grade)
        {
            var books = await Model.GetAllBooks();
            IEnumerable<Book> booksWithGivenGrade = books.Where(book=>book.Grade == int.Parse(grade));
            Books.Clear();
            List<BookViewModel> booksViewModel = new List<BookViewModel>();
            foreach (var book in booksWithGivenGrade)
            { 
                booksViewModel.Add(new BookViewModel(book));
            }
            Books.Add(new BookGroupViewModel(grade, booksViewModel));
        }
        public async void GetBooksByDate(string date)
        {
            var books = await Model.GetAllBooks();
            IEnumerable<Book> booksWithGivenDate = books.Where(book => book.ParutionYear == int.Parse(date));
            Books.Clear();
            List<BookViewModel> booksViewModel = new List<BookViewModel>();
            foreach (var book in booksWithGivenDate)
            {
                booksViewModel.Add(new BookViewModel(book));
            }
            Books.Add(new BookGroupViewModel(date, booksViewModel));
        }

        public async void GetBooksByAuthor(string author)
        {
            var books = await Model.GetAllBooks();
            IEnumerable<Book> booksWithGivenAuthor = books.Where(book => book.Author == author);
            Books.Clear();
            List<BookViewModel> booksViewModel = new List<BookViewModel>();
            foreach (var book in booksWithGivenAuthor)
            {
                booksViewModel.Add(new BookViewModel(book));
            }
            Books.Add(new BookGroupViewModel(author, booksViewModel));
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
            Filter = 1;
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
        public ManagerViewModel(ILibraryManager libMng, IUserLibraryManager userLibMng)
        {
            Model = new Manager(libMng,userLibMng);
            ReverseListCommand = new Command<string>(ReverseList);
            GetLendsCommand = new Command(GetLends);
            GetBorrowsCommand = new Command(GetBorrows);
        }

    }
}
