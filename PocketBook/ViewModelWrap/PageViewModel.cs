using MyToolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelWrapper
{
    public class PageViewModel: BaseViewModelWrapper<PageViewModel>
    {
        public int NumberOfPages { get => nbOfPages; set => SetProperty(ref nbOfPages, value, () => { nbOfPages = value; }); }
        private int nbOfPages;
        public int CurrentPage { get => currentPage; set => SetProperty(ref currentPage, value, () => { currentPage = value; }); }
        private int currentPage;

        public PageViewModel(int _nbpages,int _currentpage) 
        {
            NumberOfPages = _nbpages;
            CurrentPage = _currentpage;
        }
    }
}
