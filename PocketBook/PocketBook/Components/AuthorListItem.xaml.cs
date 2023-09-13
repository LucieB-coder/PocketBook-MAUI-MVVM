namespace PocketBook.Components;

public partial class AuthorListItem : ContentView
{
    public static readonly BindableProperty AuthorNameProperty = BindableProperty.Create(nameof(AuthorName), typeof(string), typeof(AuthorListItem), string.Empty);
    public static readonly BindableProperty NumberOfElementsProperty = BindableProperty.Create(nameof(NumberOfElements), typeof(string), typeof(AuthorListItem), string.Empty);
    public string AuthorName
    {
        get => (string)GetValue(AuthorListItem.AuthorNameProperty);
        set => SetValue(AuthorListItem.AuthorNameProperty, value);
    }

    public string NumberOfElements
    {
        get => (string)GetValue(AuthorListItem.NumberOfElementsProperty);
        set => SetValue(AuthorListItem.NumberOfElementsProperty, value);
    }

    public AuthorListItem()
	{
		InitializeComponent();
	}

    async void OnAllClicked(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//AllBooks", false);
    }
}