using PocketBook.ViewModel;
using System.Collections.ObjectModel;

namespace PocketBook.Pages;

public partial class LendBooksPage : ContentPage
{
    public NavigationViewModel NavigationViewModel { get; set; } = new NavigationViewModel();

    public LendBooksPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    void OnLendsClicked(object sender, EventArgs args)
    {
        LendsButton.BackgroundColor = Colors.White;
        RentsButton.BackgroundColor = Colors.Transparent;

    }
     void OnRentsClicked(object sender, EventArgs args)
    {
        LendsButton.BackgroundColor = Colors.Transparent;
        RentsButton.BackgroundColor = Colors.White;
    }
}


