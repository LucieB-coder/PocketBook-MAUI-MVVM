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

        public LoadBooksNavigationViewModel(ManagerViewModel mngVm)
        {
            ManagerVM = mngVm;
            NavigateToBooksPageCommand = new Command<string>(NavigateToBooksPage);
            NavigateToBookDetailsCommand = new Command<int>(NavigateToBookDetails);
        }

        private async void NavigateToBooksPage(string filter)
        {
            if (filter == "all") ManagerVM.GetAllBooks();
            switch (filter.Length)
            {
                case 1:
                    ManagerVM.GetBooksByGrade(filter);
                    break;
                case 4:
                    ManagerVM.GetBooksByDate(filter);
                    break;
                default:
                    {
                        ManagerVM.GetBooksByAuthor(filter);
                        break;
                    }
            }
            await Shell.Current.GoToAsync("AllBooksPage");
        }

        private async void NavigateToBookDetails(int bookId)
        {
            ManagerVM.GetBookById(bookId);
            await Shell.Current.GoToAsync("OneBookPage");
        }
    }
}
