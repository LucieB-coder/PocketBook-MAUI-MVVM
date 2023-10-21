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
    public class ListManagerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private ManagerViewModel ManagerVM { get; set; }

        public ICommand ReverseListCommand { get; set; }
        public ListManagerViewModel(ManagerViewModel mngVm)
        {
            ManagerVM = mngVm;
            ReverseListCommand = new Command(ReverseList);
        }

        private void ReverseList()
        {
            ManagerVM.ReverseList();
        }
    }
}
