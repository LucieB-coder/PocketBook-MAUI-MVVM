using PocketBook.ViewModel;
using ViewModelWrapper;

namespace PocketBook.Pages;

public partial class LibraryPage : ContentPage
{
	public LoadBooksNavigationViewModel LoaderNavigationVM { get; set; }

	public ListManagerViewModel ListManagerVM { get; set; }
	public NavigationViewModel NavigationVM { get; set; } = new NavigationViewModel();
    public LibraryPage(ManagerViewModel mngVM)
	{
		ListManagerVM = new ListManagerViewModel(mngVM);
        LoaderNavigationVM = new LoadBooksNavigationViewModel(mngVM);
		InitializeComponent();
		BindingContext = this;
	}
}