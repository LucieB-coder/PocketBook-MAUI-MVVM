namespace Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<int> Authors { get; set; }
        public string CoverImage { get; set; }
        public string ReadingStatus { get; set; }
        public int Grade { get; set; }

        public Book() { }
    }
}

