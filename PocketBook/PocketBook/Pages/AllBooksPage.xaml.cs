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
    public BookViewModel BookVM { get; set; }

    public IEnumerable<Book> Books { get; set; }
    public AllBooksPage(BookViewModel bookVM)
	{
        BookVM = bookVM;
        Books = BookVM.GetAllBooks();
        InitializeComponent();
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