using PocketBook.ViewModel;
using ViewModelWrapper;

namespace PocketBook.Pages;

public partial class FilterPage : ContentPage
{
    public NavigationViewModel NavigationViewModel { get; set; } = new NavigationViewModel();
    public LoadBooksNavigationViewModel LoaderDataVM { get; set; }
    public ManagerViewModel ManagerVM { get; set; }
    public FilterViewModel PageTitle { get;set; }
	public IEnumerable<FilterItemViewModel> Filters { get; set; }
    public FilterPage(ManagerViewModel mngVM)
	{
		ManagerVM = mngVM;
        LoaderDataVM = new LoadBooksNavigationViewModel(mngVM);
		Filters = ManagerVM.FilteredItemList;
        PageTitle = ManagerVM.Filter;
        InitializeComponent();
        BindingContext = this;
	}
}