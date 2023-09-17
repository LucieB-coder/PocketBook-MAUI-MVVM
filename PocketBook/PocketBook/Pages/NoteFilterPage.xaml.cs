namespace PocketBook.Pages;

public partial class NoteFilterPage : ContentPage
{
	public NoteFilterPage()
	{
		InitializeComponent();
	}

    async void OnGoBack(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//Library");
    }
}