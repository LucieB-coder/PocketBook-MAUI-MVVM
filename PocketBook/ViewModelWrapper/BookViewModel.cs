using System.ComponentModel;
using Model;
using MyToolkit;

namespace ViewModelWrapper
{
    public class BookViewModel : BaseViewModelWrapper<BookViewModel>
    {
        private Book Model { get; set; }

        #region wrapping

        public int Id { get => Model.Id; }
        public string Title { get => Model.Title; }
        public string Description { get => Model.Description; }
        public string Author { get => Model.Author; }
        public string CoverImage { get => Model.CoverImage; }
        public string ReadingStatus { get => Model.ReadingStatus; }
        public int Grade { get => Model.Grade; }

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