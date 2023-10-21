using PocketBook.ViewModel;
using ViewModelWrapper;

namespace PocketBook.Pages;

public partial class FilterPage : ContentPage
{
    public NavigationViewModel NavigationViewModel { get; set; } = new NavigationViewModel();
    public ListManagerViewModel ListManagerVM { get; set; }
    public ManagerViewModel ManagerVM { get; set; }
	public IEnumerable<FilterItemViewModel> Authors { get; set; }
    public FilterPage(ManagerViewModel mngVM)
	{
		ManagerVM = mngVM;
        ListManagerVM = new ListManagerViewModel(mngVM);
		Authors = ManagerVM.FilteredItemList;
		InitializeComponent();
        switch (ManagerVM.Filter)
        {
            case 1:
                page_title.Text = "Auteur";
                break;
            case 2:
                page_title.Text = "date de publication";
                break;
            case 3:
                page_title.Text = "Notes";
                break;
        }
        BindingContext = this;
	}
}