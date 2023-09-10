namespace PocketBook.Components;

public partial class BookSection : ContentView
{
    public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(nameof(ImageSource), typeof(string), typeof(BookSection), string.Empty);
    public static readonly BindableProperty BookNameProperty = BindableProperty.Create(nameof(BookName), typeof(string), typeof(BookSection), string.Empty);
    public static readonly BindableProperty AuthorNameProperty = BindableProperty.Create(nameof(AuthorName), typeof(string), typeof(BookSection), string.Empty);
    public static readonly BindableProperty StatusProperty = BindableProperty.Create(nameof(Status), typeof(string), typeof(BookSection), string.Empty);

    public string ImageSource
    {
        get => (string)GetValue(BookSection.ImageSourceProperty);
        set => SetValue(BookSection.ImageSourceProperty, value);
    }
    public string BookName
    {
        get => (string)GetValue(BookSection.BookNameProperty);
        set => SetValue(BookSection.BookNameProperty, value);
    }

    public string AuthorName
    {
        get => (string)GetValue(BookSection.AuthorNameProperty);
        set => SetValue(BookSection.AuthorNameProperty, value);
    }

    public string Status
    {
        get => (string)GetValue(BookSection.StatusProperty);
        set => SetValue(BookSection.StatusProperty, value);
    }

    public BookSection()
	{
		InitializeComponent();
	}
}