using CommunityToolkit.Maui.Views;
using PocketBook.Components;
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

    void OnAddBook(object sender, EventArgs args)
    {
        if (popup.ZIndex == 0)
        {
            popup.ZIndex = 2;
        }
        else
        {
            popup.ZIndex = 0;
        }
    }

}