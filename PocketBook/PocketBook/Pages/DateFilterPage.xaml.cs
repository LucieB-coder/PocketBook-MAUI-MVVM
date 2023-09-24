using PocketBook.ViewModel;

namespace PocketBook.Pages;

public partial class DateFilterPage : ContentPage
{
    public NavigationViewModel NavigationViewModel { get; set; } = new NavigationViewModel();
    public DateFilterPage()
	{
		InitializeComponent();
		BindingContext = this;
	}
}