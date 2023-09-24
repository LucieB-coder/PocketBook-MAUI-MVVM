using PocketBook.ViewModel;

namespace PocketBook.Components;

public partial class AddBookPopup
{
    public NavigationViewModel NavigationViewModel { get; set; } = new NavigationViewModel();

    public AddBookPopup()
	{
		InitializeComponent();
		BindingContext = this;
	}
}