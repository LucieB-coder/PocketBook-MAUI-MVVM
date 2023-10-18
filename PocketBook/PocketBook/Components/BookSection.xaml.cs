using Model;
using PocketBook.ViewModel;
using System.Windows.Input;

namespace PocketBook.Components;

public partial class BookSection : ContentView
{
    public static readonly BindableProperty CoverImageProperty = 
        BindableProperty.Create(nameof(CoverImage), typeof(string), typeof(BookSection), string.Empty);
    public static readonly BindableProperty TitleProperty = 
        BindableProperty.Create(nameof(Title), typeof(string), typeof(BookSection), string.Empty);
    public static readonly BindableProperty AuthorNameProperty = 
        BindableProperty.Create(nameof(AuthorName), typeof(string), typeof(BookSection), string.Empty);
    public static readonly BindableProperty ReadingStatusProperty = 
        BindableProperty.Create(nameof(ReadingStatus), typeof(string), typeof(BookSection), string.Empty);
    public static readonly BindableProperty CommandProperty =
        BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(BookSection), null);
    public static readonly BindableProperty CommandParameterProperty =
        BindableProperty.Create(nameof(CommandParameter), typeof(object), typeof(BookSection), null);

    public string CoverImage
    {
        get => (string)GetValue(BookSection.CoverImageProperty);
        set => SetValue(BookSection.CoverImageProperty, value);
    }
    public string Title
    {
        get => (string)GetValue(BookSection.TitleProperty);
        set => SetValue(BookSection.TitleProperty, value);
    }

    public string AuthorName
    {
        get => (string)GetValue(BookSection.AuthorNameProperty);
        set => SetValue(BookSection.AuthorNameProperty, value);
    }

    public string ReadingStatus
    {
        get => (string)GetValue(BookSection.ReadingStatusProperty);
        set => SetValue(BookSection.ReadingStatusProperty, value);
    }

    public ICommand Command
    {
        get => (ICommand)GetValue(BookSection.CommandProperty);
        set => SetValue(BookSection.CommandProperty, value);
    }

    public object CommandParameter
    {
        get => GetValue(BookSection.CommandParameterProperty);
        set => SetValue(BookSection.CommandParameterProperty, value);
    }

    public BookSection()
	{
        InitializeComponent();
    }
}