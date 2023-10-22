using Android.Net.Wifi.Aware;
using PocketBook.ViewModel;
using System.Collections.ObjectModel;
using ViewModelWrapper;

namespace PocketBook.Pages;

public partial class LendBooksPage : ContentPage
{
    public NavigationViewModel NavigationViewModel { get; set; } = new NavigationViewModel();
    public ManagerViewModel ManagerVM { get; set; }
    public LoadBooksNavigationViewModel LoadBooksNavigationVM { get; set; }
    public IEnumerable<BookGroupViewModel> Lends { get; set; } 

    public LendBooksPage(ManagerViewModel mngVM)
    {
        ManagerVM = mngVM;
        LoadBooksNavigationVM = new LoadBooksNavigationViewModel(mngVM);
        Lends = ManagerVM.Books;
        InitializeComponent();
        BindingContext = this;
    }

    void OnLendsClicked(object sender, EventArgs args)
    {
        LendsButton.BackgroundColor = Colors.White;
        RentsButton.BackgroundColor = Colors.Transparent;

    }
     void OnBorrowsClicked(object sender, EventArgs args)
    {
        LendsButton.BackgroundColor = Colors.Transparent;
        RentsButton.BackgroundColor = Colors.White;
    }
}


