using PocketBook.Pages;

namespace PocketBook
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(LibraryPage),typeof(LibraryPage));
            Routing.RegisterRoute(nameof(AllBooksPage),typeof(AllBooksPage));
            Routing.RegisterRoute(nameof(OneBookPage), typeof(OneBookPage));
            Routing.RegisterRoute(nameof(LendBooksPage), typeof(LendBooksPage));
            Routing.RegisterRoute(nameof(AuthorFilterPage), typeof(AuthorFilterPage));
            Routing.RegisterRoute(nameof(DateFilterPage), typeof(DateFilterPage));
            Routing.RegisterRoute(nameof(NoteFilterPage), typeof(NoteFilterPage));
        }
    }
}