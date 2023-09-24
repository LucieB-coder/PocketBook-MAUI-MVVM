namespace PocketBook.Components;

public partial class BookCover : ContentView
{
    public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(nameof(ImageSource), typeof(string), typeof(BookCover), string.Empty);

    public string ImageSource
    {
        get => (string)GetValue(BookCover.ImageSourceProperty);
        set => SetValue(BookCover.ImageSourceProperty, value);
    }
    public BookCover()
	{
		InitializeComponent();
        BindingContext = this;
	}
}