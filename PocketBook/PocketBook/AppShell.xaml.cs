using PocketBook.Pages;

namespace PocketBook
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AllBooksPage),typeof(AllBooksPage));
        }
    }
}