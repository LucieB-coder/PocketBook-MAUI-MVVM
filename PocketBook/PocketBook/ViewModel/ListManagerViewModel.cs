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
        public ICommand GetFilterListCommand { get;set; }
        public ListManagerViewModel(ManagerViewModel mngVm)
        {
            ManagerVM = mngVm;
            ReverseListCommand = new Command<string>(ReverseList);
            GetFilterListCommand = new Command<string>(GetFilterList);
        }

        private void ReverseList(string list)
        {
            ManagerVM.ReverseList(list);
        }

        private void GetFilterList(string filter) 
        {
            NavigationViewModel navVM = new NavigationViewModel();
            switch (filter)
            {
                case "author":
                    ManagerVM.GetAuthorsList();
                    navVM.NavigateCommand.Execute("FilterPage");
                    break;
                case "grade":
                    ManagerVM.GetGradesList();
                    navVM.NavigateCommand.Execute("FilterPage");
                    break;
                default:
                    {
                        ManagerVM.GetAllBooks();
                        break;
                    }
            }
        }
    }
}
