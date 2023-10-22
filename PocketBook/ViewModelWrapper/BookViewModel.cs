using System.ComponentModel;
using Model;
using MyToolkit;

namespace ViewModelWrapper
{
    public class BookViewModel : BaseViewModelWrapper<BookViewModel>
    {
        public Book Model { get; set; }

        #region wrapping
        
        public int Id { get => id; set => SetProperty(ref id, value, () => { id = value; });}
        private int id;
        public string Title { get => title; set => SetProperty(ref title, value, () => { title = value; }); }
        private string title;
        public string Description { get => description; set => SetProperty(ref description, value, () => { description = value; }); }
        private string description;
        public string Author { get => author; set => SetProperty(ref author, value, () => { author = value; }); }
        private string author;
        public string CoverImage { get => coverImage; set => SetProperty(ref coverImage, value, () => { coverImage = value; }); }
        private string coverImage;
        public string ReadingStatus { get => readingStatus; set => SetProperty(ref readingStatus, value, () => { readingStatus = value; }); }
        private string readingStatus;
        public int Grade { get => grade; set => SetProperty(ref grade, value, () => { grade = value; }); }
        private int grade;
        public DateTime AddedOnLibraryDate { get => addedOnLibraryDate; set => SetProperty(ref addedOnLibraryDate, value, () => { addedOnLibraryDate = value; }); }
        private DateTime addedOnLibraryDate;
        public double NumberOfPages { get => numberOfPages; set => SetProperty(ref numberOfPages, value, () => { numberOfPages = value; }); }
        private double numberOfPages;
        public string ISBN { get => isbn; set => SetProperty(ref isbn, value, () => { isbn = value; }); }
        private string isbn;
        public string PublishingHouse { get => publishingHouse; set => SetProperty(ref publishingHouse, value, () => { publishingHouse = value; }); }
        private string publishingHouse;
        public int ParutionYear { get => parutionYear; set => SetProperty(ref parutionYear, value, () => { parutionYear = value; }); }
        private int parutionYear;

        #endregion

        #region constructor

        public BookViewModel(Book book) 
        {
            Model = book;
            Id = Model.Id;
            Title = Model.Title;
            Description = Model.Description;
            Author = Model.Author;
            CoverImage = Model.CoverImage;
            ReadingStatus = Model.ReadingStatus;
            Grade = Model.Grade;
            AddedOnLibraryDate = Model.AddedOnLibraryDate;
            NumberOfPages = Model.NumberOfPages;
            ISBN = Model.ISBN;
            PublishingHouse = Model.PublishingHouse;
            ParutionYear = Model.ParutionYear;
        }

        public BookViewModel() { }

        #endregion
    }
}