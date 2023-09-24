using CommunityToolkit.Maui.Views;
using PocketBook.Components;
using PocketBook.ViewModel;
using System.Collections.ObjectModel;
using ViewModelWrapper;
using Model;

namespace PocketBook.Pages;

public partial class AllBooksPage : ContentPage
{      
    public NavigationViewModel NavigationViewModel { get; set; } = new NavigationViewModel();
    public BookViewModel BookViewModel { get; set; } = new BookViewModel();
    public ILibraryManager LibraryManager { get; set; } = DependencyService.Get<ILibraryManager>();
    public AllBooksPage()
	{
        InitializeComponent();
        DisplayedCollection.ItemsSource = BookViewModel.GetAllBooks(LibraryManager);
        BindingContext = this;
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