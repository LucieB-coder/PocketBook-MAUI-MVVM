namespace PocketBook.Pages;

public partial class AuthorsPage : ContentPage
{
	public AuthorsPage()
	{
		InitializeComponent();
	}

    async void OnGoBack(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//Library");
    }
}