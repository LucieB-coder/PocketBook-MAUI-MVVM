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
        public ICommand GetLendsCommand { get; set; }
        public ICommand GetBorrowsCommand { get; set; }
        public ListManagerViewModel(ManagerViewModel mngVm)
        {
            ManagerVM = mngVm;
            ReverseListCommand = new Command<string>(ReverseList);
            GetLendsCommand = new Command(GetLends);
            GetBorrowsCommand = new Command(GetBorrows);
        }

        private void ReverseList(string list)
        {
            ManagerVM.ReverseList(list);
        }

        private void GetLends()
        {
            ManagerVM.GetLends();
        }

        private void GetBorrows()
        {
            ManagerVM.GetBorrows();
        }
    }
}
