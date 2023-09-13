namespace PocketBook.Pages;

public partial class OneBookPage : ContentPage
{
	public OneBookPage()
	{
		InitializeComponent();
	}

    async void OnGoBack(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//Library");
    }
}