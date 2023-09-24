using PocketBook.ViewModel;

namespace PocketBook.Pages;

public partial class AuthorFilterPage : ContentPage
{
    public NavigationViewModel NavigationViewModel { get; set; } = new NavigationViewModel();

    public AuthorFilterPage()
	{
		InitializeComponent();
		BindingContext = this;
	}
}