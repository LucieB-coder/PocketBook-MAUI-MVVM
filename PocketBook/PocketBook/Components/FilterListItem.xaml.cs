using PocketBook.ViewModel;
using System.Windows.Input;

namespace PocketBook.Components;

public partial class FilterListItem : ContentView
{
    public static readonly BindableProperty NameProperty = 
        BindableProperty.Create(nameof(Name), typeof(string), typeof(FilterListItem), string.Empty);
    public static readonly BindableProperty NumberOfElementsProperty = 
        BindableProperty.Create(nameof(NumberOfElements), typeof(string), typeof(FilterListItem), string.Empty);
    public static readonly BindableProperty CommandProperty =
        BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(FilterListItem), null);
    public static readonly BindableProperty CommandParameterProperty =
        BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(FilterListItem), null);
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

    public ICommand Command
    {
        get => (ICommand)GetValue(FilterListItem.CommandProperty);
        set => SetValue(FilterListItem.CommandProperty, value);
    }

    public object CommandParameter
    {
        get => GetValue(FilterListItem.CommandParameterProperty);
        set => SetValue(FilterListItem.CommandParameterProperty, value);
    }


    public FilterListItem()
	{
		InitializeComponent();
	}

}