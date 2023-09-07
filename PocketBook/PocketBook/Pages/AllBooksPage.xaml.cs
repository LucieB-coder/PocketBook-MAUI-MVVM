namespace PocketBook.Pages;

public partial class AllBooksPage : ContentPage
{
	public AllBooksPage()
	{
		InitializeComponent();
	}

    async void OnGoBack(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//Library");
    }
}