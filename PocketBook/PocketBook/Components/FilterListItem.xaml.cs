using PocketBook.ViewModel;

namespace PocketBook.Components;

public partial class FilterListItem : ContentView
{
    public static readonly BindableProperty AuthorNameProperty = BindableProperty.Create(nameof(AuthorName), typeof(string), typeof(FilterListItem), string.Empty);
    public static readonly BindableProperty NumberOfElementsProperty = BindableProperty.Create(nameof(NumberOfElements), typeof(string), typeof(FilterListItem), string.Empty);
    public string AuthorName
    {
        get => (string)GetValue(FilterListItem.AuthorNameProperty);
        set => SetValue(FilterListItem.AuthorNameProperty, value);
    }

    public string NumberOfElements
    {
        get => (string)GetValue(FilterListItem.NumberOfElementsProperty);
        set => SetValue(FilterListItem.NumberOfElementsProperty, value);
    }

    public NavigationViewModel NavigationViewModel { get; set; } = new NavigationViewModel();

    public FilterListItem()
	{
		InitializeComponent();
        BindingContext = this;
	}

}