namespace ViewModelWrapper
{
    public class BookGroupViewModel : List<BookViewModel>
    {
        public string Name { get; set; }

        public BookGroupViewModel(string authorName, List<BookViewModel> books) : base(books)
        {
            Name = authorName;
        }
    }
}