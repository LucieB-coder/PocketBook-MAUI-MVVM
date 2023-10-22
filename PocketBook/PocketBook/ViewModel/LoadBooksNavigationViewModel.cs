using Stub;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ViewModelWrapper;

namespace PocketBook.ViewModel
{
    public class LoadBooksNavigationViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ManagerViewModel ManagerVM { get; set; }

        public ICommand NavigateToBooksPageCommand { get; set; }
        public ICommand NavigateToBookDetailsCommand { get; set; }
        public ICommand NavigateToLendsPageCommand { get; set; }
        public ICommand NavigateToFilterPageCommand { get; set; }

        public LoadBooksNavigationViewModel(ManagerViewModel mngVm)
        {
            ManagerVM = mngVm;
            NavigateToBooksPageCommand = new Command<string>(NavigateToBooksPage);
            NavigateToBookDetailsCommand = new Command<int>(NavigateToBookDetails);
            NavigateToLendsPageCommand = new Command(NavigateToLendsPage);
            NavigateToFilterPageCommand = new Command<string>(NavigateToFilterPage);
        }

        private async void NavigateToLendsPage()
        {
            ManagerVM.GetLends();
            await Shell.Current.GoToAsync("LendBooksPage");
        }

        private async void NavigateToBooksPage(string filter)
        {
            switch (filter.Length)
            {
                case 0:
                    ManagerVM.GetAllBooks();
                    break;
                case 1:
                    ManagerVM.GetBooksByGrade(filter);
                    break;
                case 4:
                    ManagerVM.GetBooksByDate(filter);
                    break;
                default:
                    ManagerVM.GetBooksByAuthor(filter);
                    break;
            }
            await Shell.Current.GoToAsync("AllBooksPage");
        }

        private async void NavigateToBookDetails(int bookId)
        {
            ManagerVM.GetBookById(bookId);
            await Shell.Current.GoToAsync("OneBookPage");
        }

        private async void NavigateToFilterPage(string filter)
        {
            switch (filter)
            {
                case "author":
                    ManagerVM.GetAuthorsList();
                    break;
                case "date":
                    ManagerVM.GetDatesList();
                    break;
                case "grade":
                    ManagerVM.GetGradesList();
                    break;
                default:
                    ManagerVM.GetAllBooks();
                    break;
            }
            await Shell.Current.GoToAsync("FilterPage");
        }
    }
}
