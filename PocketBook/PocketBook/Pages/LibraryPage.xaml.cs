using PocketBook.ViewModel;
using ViewModelWrapper;

namespace PocketBook.Pages;

public partial class LibraryPage : ContentPage
{
	public LoadBooksNavigationViewModel LoaderNavigationVM { get; set; }

	public NavigationViewModel NavigationVM { get; set; } = new NavigationViewModel();
    public LibraryPage(ManagerViewModel mngVM)
	{
        LoaderNavigationVM = new LoadBooksNavigationViewModel(mngVM);
		InitializeComponent();
		BindingContext = this;
	}
}