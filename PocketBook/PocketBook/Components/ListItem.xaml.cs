namespace PocketBook.Components;

public partial class ListItem : ContentView
{
    public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(nameof(ImageSource), typeof(string), typeof(ListItem), string.Empty);
    public static readonly BindableProperty ItemNameProperty = BindableProperty.Create(nameof(ItemName), typeof(string), typeof(ListItem), string.Empty);
    public static readonly BindableProperty NumberOfElementsProperty = BindableProperty.Create(nameof(NumberOfElements), typeof(string), typeof(ListItem), string.Empty);

    public string ImageSource
    {
        get => (string)GetValue(ListItem.ImageSourceProperty);
        set => SetValue(ListItem.ImageSourceProperty, value);
    }
    public string ItemName
    {
        get => (string)GetValue(ListItem.ItemNameProperty);
        set => SetValue(ListItem.ItemNameProperty, value);
    }

    public string NumberOfElements
    {
        get => (string)GetValue(ListItem.NumberOfElementsProperty);
        set => SetValue(ListItem.NumberOfElementsProperty, value);
    }
    public ListItem()
	{
		InitializeComponent();
    }

    async void OnAllClicked(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//AllBooks", false);
    }
}