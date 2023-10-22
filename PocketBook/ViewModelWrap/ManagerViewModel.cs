using Model;
using MyToolkit;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ViewModelWrapper
{
    public class ManagerViewModel : BaseViewModelWrapper<ManagerViewModel>
    {
        public Manager Model { get; set; }
        public ObservableCollection<FilterItemViewModel> FilteredItemList { get; set; } = new ObservableCollection<FilterItemViewModel>();
        public ObservableCollection<BookGroupViewModel> Books { get; set; } = new ObservableCollection<BookGroupViewModel>();
        public BookGroupViewModel Favorites { get; set; } = new BookGroupViewModel("Favorites", new List<BookViewModel>());
        public BookViewModel BookVM { get; set; } = new BookViewModel();
        public PageViewModel PageVM { get; set; } = new PageViewModel(1, 1);
        public FilterViewModel Filter { get; set ; } = new FilterViewModel("","");

        public ICommand ReverseListCommand { get; set; }
        public ICommand GetLendsCommand { get; set; }
        public ICommand GetBorrowsCommand { get; set; }
        public RelayCommandObject GoToPreviousPageCommand {  get; set; }
        public RelayCommandObject GoToNextPageCommand { get; set; }
        public RelayCommandObject AddToFavoritesCommand { get; set; }

        public async Task GetAllBooks()
        {
            Filter.Content = "";
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
            LoadNumberOfPages();
        }

        public async void LoadBooksByPage(int page)
        {
            PageVM.CurrentPage = page;
            Books.Clear();
            await GetAllBooks();
            for (int i = Books.Count() - 1; i > (page * 2) - 1; i--)
            {
                Books.RemoveAt(i);
            }
            for (int i = 0; i < (page-1)*2; i++)
            {
                Books.RemoveAt(0);
            }
            GoToPreviousPageCommand.Refresh();
            GoToNextPageCommand.Refresh();
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
        public async Task GetBooksByGrade(string grade)
        {
            Filter.Content = grade;
            var books = await Model.GetAllBooks();
            IEnumerable<Book> booksWithGivenGrade = books.Where(book=>book.Grade == int.Parse(grade));
            Books.Clear();
            List<BookViewModel> booksViewModel = new List<BookViewModel>();
            foreach (var book in booksWithGivenGrade)
            { 
                booksViewModel.Add(new BookViewModel(book));
            }
            Books.Add(new BookGroupViewModel(Filter.Content, booksViewModel));
            LoadNumberOfPages();
        }
        public async Task GetBooksByDate(string date)
        {
            Filter.Content = date;
            var books = await Model.GetAllBooks();
            IEnumerable<Book> booksWithGivenDate = books.Where(book => book.ParutionYear == int.Parse(date));
            Books.Clear();
            List<BookViewModel> booksViewModel = new List<BookViewModel>();
            foreach (var book in booksWithGivenDate)
            {
                booksViewModel.Add(new BookViewModel(book));
            }
            Books.Add(new BookGroupViewModel(Filter.Content, booksViewModel));
            LoadNumberOfPages();
        }

        public async Task GetBooksByAuthor(string author)
        {
            Filter.Content = author;
            var books = await Model.GetAllBooks();
            IEnumerable<Book> booksWithGivenAuthor = books.Where(book => book.Author == author);
            Books.Clear();
            List<BookViewModel> booksViewModel = new List<BookViewModel>();
            foreach (var book in booksWithGivenAuthor)
            {
                booksViewModel.Add(new BookViewModel(book));
            }
            Books.Add(new BookGroupViewModel(Filter.Content, booksViewModel));
            LoadNumberOfPages();
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
            Filter.Type = "author";
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
            Filter.Type = "grade";
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
            Filter.Type = "date";
            var books = await Model.GetAllBooks();
            IEnumerable<int> dates = books.Select(book => book.ParutionYear).Distinct();
            FilteredItemList.Clear();
            foreach (var date in dates)
            {
                int countBooks = books.Count(book => book.ParutionYear == date);
                FilteredItemList.Add(new FilterItemViewModel(date.ToString(), countBooks.ToString()));
            }
        }

        public void LoadNumberOfPages()
        {
            var books = Books;
            int count = books.Count();
            if (count % 2 == 0)
            {
                PageVM.NumberOfPages = count / 2;
            }
            else
            {
                PageVM.NumberOfPages = (count / 2) + 1;
            }
        }

        public void AddBookToFavorites(BookViewModel book)
        {                                                                                                                                            
            Model.AddBookToFavorites(
                new Book(book.Id, 
                book.Title, 
                book.Description, 
                book.Author, 
                book.CoverImage, 
                book.ReadingStatus, 
                book.Grade, 
                book.AddedOnLibraryDate, 
                book.NumberOfPages,
                book.ISBN, 
                book.PublishingHouse, 
                book.ParutionYear));
            Favorites.Items.Add(book);
        }

        public async void GetFavorites()
        {
            Favorites.Items.Clear();
            IEnumerable<Book> favorites = await Model.GetFavorites();
            foreach(Book book in favorites)
            {
                Favorites.Items.Add(new BookViewModel(book));
            }
            
        }

        public ManagerViewModel(ILibraryManager libMng, IUserLibraryManager userLibMng)
        {
            Model = new Manager(libMng,userLibMng);
            ReverseListCommand = new RelayCommandObject(execute: async (o) => ReverseList((string)o), canExecute: (o) => true);
            GetLendsCommand = new RelayCommandObject(execute: async (o) => GetLends(), canExecute: (o) => true);
            GetBorrowsCommand = new RelayCommandObject(execute: async (o) => GetBorrows(), canExecute: (o) => true);
            GoToPreviousPageCommand = new RelayCommandObject(execute: async (o) => LoadBooksByPage(PageVM.CurrentPage - 1), canExecute: (o) => 
            {
                if (PageVM.CurrentPage == 1)
                {
                    return false;
                }
                return true;
            });
            GoToNextPageCommand = new RelayCommandObject(execute: async (o) => LoadBooksByPage(PageVM.CurrentPage + 1), canExecute: (o) =>
            {
                if (PageVM.CurrentPage == PageVM.NumberOfPages)
                {
                    return false;
                }
                return true;
            });
            AddToFavoritesCommand = new RelayCommandObject(execute: async (o) => AddBookToFavorites((BookViewModel)o), canExecute: (o) =>
            {
                if (Favorites.Items.Contains((BookViewModel)o))
                {
                    return false;
                }
                return true;
            });
        }

    }
}
