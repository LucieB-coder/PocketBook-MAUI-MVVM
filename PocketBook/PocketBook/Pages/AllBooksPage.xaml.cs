using CommunityToolkit.Maui.Views;
using PocketBook.Components;
using PocketBook.ViewModel;
using System.Collections.ObjectModel;
using ViewModelWrapper;

namespace PocketBook.Pages;

public partial class AllBooksPage : ContentPage
{
    public NavigationViewModel NavigationViewModel { get; set; } = new NavigationViewModel(); 

    public LoadBooksNavigationViewModel LoadNavigationVM { get; set; }
    public ManagerViewModel ManagerVM { get; set; }
    public IEnumerable<BookViewModel> Books { get; set; }
    public AllBooksPage(ManagerViewModel mngVM)
	{
        LoadNavigationVM = new LoadBooksNavigationViewModel(mngVM);
        ManagerVM = mngVM;
        Books = ManagerVM.Books;
        InitializeComponent();
        BindingContext = this;
    }
    void OnAddBook(object sender, EventArgs args)
    {
        if (popup.ZIndex == 0)
        {
            popup.ZIndex = 2;
        }
        else
        {
            popup.ZIndex = 0;
        }
    }

}