using PocketBook.ViewModel;

namespace PocketBook.Pages;

public partial class OneBookPage : ContentPage
{
    public NavigationViewModel NavigationViewModel { get; set; } = new NavigationViewModel();
    public OneBookPage()
	{
		InitializeComponent();
		BindingContext = this;
	}
}