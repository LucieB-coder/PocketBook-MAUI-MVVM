using CommunityToolkit.Maui.Views;
using PocketBook.Components;
using System.Collections.ObjectModel;

namespace PocketBook.Pages;

public partial class AllBooksPage : ContentPage
{
    private readonly Collection<Person> authorsAndBooks = new Collection<Person> 
    { 
        new Person("Alain Damasio", new Collection<Book> 
        { 
            new Book("La horde du contrevent", "la_horde_du_contrevent", "Alain Damasio", "Non lu", 0),
            new Book("La zone du dehors", "la_zone_du_dehors", "Alain Damasio", "Termin�", 0)
        }) ,
        new Person("Cixin Liu", new Collection<Book> 
        { 
            new Book("L'�quateur d'Einstein", "l_equateur_d_einstein", "Cixin Liu", "Termin�", 4),
            new Book("La for�t sombre", "la_foret_sombre", "Cixin Liu", "Termin�", 4),
            new Book("Le probl�me � trois corps", "le_probleme_a_trois_corps", "Cixin Liu", "Termin�", 4)
        }),
        new Person("Franck Thilliez", new Collection<Book> 
        { 
            new Book("1991", "franck_thilliez_1991", "Franck Thilliez", "Non lu", 4),
            new Book("Labyrinthes", "labyrinthes", "Franck Thilliez", "En cours", 4),
            new Book("Au del� de l'horizon", "au_dela_de_l_horizon", "Franck Thilliez", "Termin�", 4)
        })
    };

    public AllBooksPage()
	{
		InitializeComponent();
        DisplayedCollection.ItemsSource= authorsAndBooks;
	}

    async void OnGoBack(object sender, EventArgs args)
    {
        await Shell.Current.GoToAsync("//Library");
    }

    void OnAddBook(object sender, EventArgs args)
    {
        if (popup.ZIndex == 0)
        {
            popup.ZIndex = 2;
        }
        else
        {
            popup.ZIndex = 0;
        }
    }

}