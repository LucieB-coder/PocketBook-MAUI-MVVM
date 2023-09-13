namespace PocketBook.Components;

public partial class BookDetailsRedButton : ContentView
{
    public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(nameof(ImageSource), typeof(string), typeof(BookDetailsRedButton), string.Empty);
    public static readonly BindableProperty ItemNameProperty = BindableProperty.Create(nameof(ItemName), typeof(string), typeof(BookDetailsRedButton), string.Empty);

    public string ImageSource
    {
        get => (string)GetValue(BookDetailsRedButton.ImageSourceProperty);
        set => SetValue(BookDetailsRedButton.ImageSourceProperty, value);
    }
    public string ItemName
    {
        get => (string)GetValue(BookDetailsRedButton.ItemNameProperty);
        set => SetValue(BookDetailsRedButton.ItemNameProperty, value);
    }
    public BookDetailsRedButton()
	{
		InitializeComponent();
	}
}