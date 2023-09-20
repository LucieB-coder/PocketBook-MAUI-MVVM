using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PocketBook.ViewModel
{
    public class NavigationViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand NavigateCommand { get; set; }

        public NavigationViewModel() 
        {
            NavigateCommand = new Command<string>(GoToRoute);
        }

        private async void GoToRoute(string route)
        {
            await Shell.Current.GoToAsync(route);
        }
    }
}
