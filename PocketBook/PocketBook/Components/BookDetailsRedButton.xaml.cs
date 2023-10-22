using MyToolkit;
using System.Windows.Input;

namespace PocketBook.Components;

public partial class BookDetailsRedButton : ContentView
{
    public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(nameof(ImageSource), typeof(string), typeof(BookDetailsRedButton), string.Empty);
    public static readonly BindableProperty ItemNameProperty = BindableProperty.Create(nameof(ItemName), typeof(string), typeof(BookDetailsRedButton), string.Empty);
    public static readonly BindableProperty CommandProperty =
        BindableProperty.Create(nameof(Command), typeof(RelayCommandObject), typeof(BookDetailsRedButton), null);
    public static readonly BindableProperty CommandParameterProperty =
        BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(BookDetailsRedButton), null);

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
    public RelayCommandObject Command
    {
        get => (RelayCommandObject)GetValue(BookDetailsRedButton.CommandProperty);
        set => SetValue(BookDetailsRedButton.CommandProperty, value);
    }

    public object CommandParameter
    {
        get => GetValue(BookDetailsRedButton.CommandParameterProperty);
        set => SetValue(BookDetailsRedButton.CommandParameterProperty, value);
    }
    public BookDetailsRedButton()
	{
		InitializeComponent();
        BindingContext = this; 
	}
    
}