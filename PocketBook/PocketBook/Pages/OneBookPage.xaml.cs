using PocketBook.ViewModel;
using Stub;
using ViewModelWrapper;

namespace PocketBook.Pages;

public partial class OneBookPage : ContentPage
{
    public NavigationViewModel NavigationViewModel { get; set; } = new NavigationViewModel();

    public BookViewModel Book { get; set; }

    public ManagerViewModel ManagerVM { get; set; }
    public OneBookPage(ManagerViewModel mngVM)
	{
        ManagerVM = mngVM;
        Book = ManagerVM.BookVM;
        BindingContext = this;
        InitializeComponent();
    }
}