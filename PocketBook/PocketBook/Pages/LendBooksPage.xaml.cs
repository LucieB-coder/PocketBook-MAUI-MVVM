using System.Collections.ObjectModel;

namespace PocketBook.Pages;

public partial class LendBooksPage : ContentPage
{
    private readonly Collection<Person> lends = new Collection<Person> { new Person("Antoine", new Collection<Book> { new Book("The Wake", "the_wake", "Scott Snyder", "Terminé", 0) }) ,
                                                new Person("Audrey Pouclet", new Collection<Book> { new Book("Les Misérables", "les_miserables", "Victor Hugo", "Terminé", 4) })};
    private readonly List<Person> rents = new List<Person> { new Person("Chloé", new Collection<Book> { new Book("Captive", "captive", "Sarah Rivens", "En cours", 0) }) };

    public LendBooksPage()
    {
        InitializeComponent();
        DisplayedCollection.ItemsSource = lends;
    }

    async void OnGoBack(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//Library");
    }
    void OnLendsClicked(object sender, EventArgs args)
    {
        LendsButton.BackgroundColor = Colors.White;
        RentsButton.BackgroundColor = new Color(225, 225, 225);
        DisplayedCollection.ItemsSource = lends;

    }
     void OnRentsClicked(object sender, EventArgs args)
    {
        LendsButton.BackgroundColor = new Color(225, 225, 225);
        RentsButton.BackgroundColor = Colors.White;
        DisplayedCollection.ItemsSource = rents;
    }
}

class Book
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


class Person
{
    public string Name { get; set; }
    public Collection<Book> Books { get; set;}
    public Person (string name, Collection<Book> books) 
    {
        Name = name;
        Books = books;
    }
}

