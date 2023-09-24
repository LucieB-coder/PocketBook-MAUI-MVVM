using Model;
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
    public class NavigationViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand NavigateCommand { get; set; }
        public ICommand DisplayModalCommand { get; set; }

        public NavigationViewModel() 
        {
            NavigateCommand = new Command<string>(GoToRoute);
            DisplayModalCommand = new Command<string>(DisplayModal);
        }

        private async void GoToRoute(string route)
        {
            await Shell.Current.GoToAsync(route);
        }

        private async void DisplayModal(string message) 
        {
            /* Is this Okay ?? */
            await Application.Current.MainPage.DisplayAlert("Info", message, "OK");
        }
    }
}
