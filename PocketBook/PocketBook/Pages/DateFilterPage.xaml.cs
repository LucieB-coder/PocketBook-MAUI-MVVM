namespace PocketBook.Pages;

public partial class DateFilterPage : ContentPage
{
	public DateFilterPage()
	{
		InitializeComponent();
	}

    async void OnGoBack(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//Library");
    }
}