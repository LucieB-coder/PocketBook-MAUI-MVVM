namespace PocketBook.Components;

public partial class AuthorSection : ContentView
{
    public static readonly BindableProperty AuthorNameProperty = BindableProperty.Create(nameof(AuthorName), typeof(string), typeof(AuthorSection), string.Empty);

    public string AuthorName
    {
        get => (string)GetValue(AuthorSection.AuthorNameProperty);
        set => SetValue(AuthorSection.AuthorNameProperty, value);
    }
    public AuthorSection()
	{
		InitializeComponent();
	}
}