using System.ComponentModel;
using Model;
using MyToolkit;

namespace ViewModelWrapper
{
    public class BookViewModel : BaseViewModelWrapper<BookViewModel>
    {
        private Book Model { get; set; } = new Book();

        #region wrapping

        public int Id 
        { 
            get => Model.Id; 
            set 
            {
                Model.Id = value;
                OnPropertyChanged();
            } 
        }
        public string Title 
        {
            get => Model.Title;
            set
            {
                Model.Title = value;
                OnPropertyChanged();
            }
        }
        public string Description
        {
            get => Model.Description;
            set
            {
                Model.Description = value;
                OnPropertyChanged();
            }
        }
        public string Author
        {
            get=> Model.Author;
            set
            {
                Model.Author = value;
                OnPropertyChanged();
            }
        }
        public string CoverImage 
        { 
            get => Model.CoverImage;
            set
            {
                Model.CoverImage = value;
                OnPropertyChanged();
            }
        }
        public string ReadingStatus 
        { 
            get => Model.ReadingStatus;
            set
            {
                Model.ReadingStatus = value;
                OnPropertyChanged();
            }
        }
        public int Grade 
        { 
            get => Model.Grade;
            set
            {
                Model.Grade = value;
                OnPropertyChanged(); 
            }
        }

        public DateTime AddedOnLibraryDate 
        {
            get => Model.AddedOnLibraryDate;
            set
            {
                Model.AddedOnLibraryDate = value;
                OnPropertyChanged();
            }
        }
        public double NumberOfPages 
        {
            get => Model.NumberOfPages;
            set
            {
                Model.NumberOfPages = value;
                OnPropertyChanged();
            }
        }
        public string ISBN 
        {
            get => Model.ISBN;
            set
            {
                Model.ISBN = value;
                OnPropertyChanged();
            }
        }
        public string PublishingHouse 
        {
            get => Model.PublishingHouse;
            set
            {
                Model.PublishingHouse = value;
                OnPropertyChanged();
            }
        }
        public int ParutionYear 
        {
            get => Model.ParutionYear;
            set
            {
                Model.ParutionYear = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region constructor

        public BookViewModel(Book book) 
        {
            Model = book;
        }

        public BookViewModel() { }

        #endregion
    }
}