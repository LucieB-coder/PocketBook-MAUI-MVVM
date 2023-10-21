using PocketBook.ViewModel;

namespace PocketBook.Components;

public partial class FilterListItem : ContentView
{
    public static readonly BindableProperty NameProperty = BindableProperty.Create(nameof(Name), typeof(string), typeof(FilterListItem), string.Empty);
    public static readonly BindableProperty NumberOfElementsProperty = BindableProperty.Create(nameof(NumberOfElements), typeof(string), typeof(FilterListItem), string.Empty);
    public string Name
    {
        get => (string)GetValue(FilterListItem.NameProperty);
        set => SetValue(FilterListItem.NameProperty, value);
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
	}

}