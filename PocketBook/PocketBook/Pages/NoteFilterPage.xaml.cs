using PocketBook.ViewModel;

namespace PocketBook.Pages;

public partial class NoteFilterPage : ContentPage
{

    public NavigationViewModel NavigationViewModel { get; set; } = new NavigationViewModel();
    public NoteFilterPage()
	{
		InitializeComponent();
		BindingContext = this;
	}
}