using PocketBook.ViewModel;
using System.Collections.ObjectModel;

namespace PocketBook.Pages;

public partial class LendBooksPage : ContentPage
{
    private readonly Collection<Person> lends = new Collection<Person> { new Person("Antoine", new List<Book> { new Book("The Wake", "the_wake", "Scott Snyder", "Terminé", 0) }) ,
                                                new Person("Audrey Pouclet", new List<Book> { new Book("Les Misérables", "les_miserables", "Victor Hugo", "Terminé", 4) })};
    private readonly List<Person> rents = new List<Person> { new Person("Chloé", new List<Book> { new Book("Captive", "captive", "Sarah Rivens", "En cours", 0) }) };

    public NavigationViewModel NavigationViewModel { get; set; } = new NavigationViewModel();

    public LendBooksPage()
    {
        InitializeComponent();
        DisplayedCollection.ItemsSource = lends;
        BindingContext = this;
    }

    void OnLendsClicked(object sender, EventArgs args)
    {
        LendsButton.BackgroundColor = Colors.White;
        RentsButton.BackgroundColor = Colors.Transparent;
        DisplayedCollection.ItemsSource = lends;

    }
     void OnRentsClicked(object sender, EventArgs args)
    {
        LendsButton.BackgroundColor = Colors.Transparent;
        RentsButton.BackgroundColor = Colors.White;
        DisplayedCollection.ItemsSource = rents;
    }
}

public class Book
{
    public string Title { get; set; }
    public string ImageSource { get; set; }
    public string AuthorName { get; set; }
    public string Status { get; set; }
    public int Grade { get; set; }
    public Book (string title, string imageSource,string authorName,string status, int grade) 
    { 
        Title = title;
        ImageSource = imageSource;
        AuthorName = authorName;
        Status = status;
        Grade = grade;
    }
}


public class Person
{
    public string Name { get; set; }
    public List<Book> Books { get; set;}
    public Person (string name, List<Book> books) 
    {
        Name = name;
        Books = books;
    }
}

