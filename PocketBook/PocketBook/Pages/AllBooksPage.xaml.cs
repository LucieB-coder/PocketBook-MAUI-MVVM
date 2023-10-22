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
    public IEnumerable<BookGroupViewModel> Books { get; set; }
    public PageViewModel PageVM { get; set; }
    public int PageIndex { get; set; }
    public int NbOfPages { get; set; }
    public int PreviousPage { get;set; }
    public int NextPage { get; set; }
    public AllBooksPage(ManagerViewModel mngVM)
	{
        LoadNavigationVM = new LoadBooksNavigationViewModel(mngVM);
        ManagerVM = mngVM;
        Books = ManagerVM.Books;
        PageVM = ManagerVM.PageVM;
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