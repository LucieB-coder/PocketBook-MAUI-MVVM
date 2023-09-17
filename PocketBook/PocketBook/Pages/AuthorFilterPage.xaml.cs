namespace PocketBook.Pages;

public partial class AuthorFilterPage : ContentPage
{
	public AuthorFilterPage()
	{
		InitializeComponent();
	}

    async void OnGoBack(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//Library");
    }
}