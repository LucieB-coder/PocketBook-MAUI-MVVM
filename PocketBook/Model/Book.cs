﻿namespace Model
{
    public class Book : IEquatable<Book>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
        public string ReadingStatus { get; set; }
        public int Grade { get; set; }
        public DateTime AddedOnLibraryDate { get; set; }
        public double NumberOfPages { get; set; }
        public string ISBN { get; set; }
        public string PublishingHouse { get; set; }
        public int ParutionYear { get; set; }

        public bool Equals(Book other)
            => Id == other.Id;

        public Book() { }
        public Book(int id, string title, string description, string author, string coverImage, string readingStatus, int grade, DateTime addedOnLibraryDate, double numberOfPages, string iSBN, string publishingHouse, int parutionYear)
        {
            Id = id;
            Title = title;
            Description = description;
            Author = author;
            CoverImage = coverImage;
            ReadingStatus = readingStatus;
            Grade = grade;
            AddedOnLibraryDate = addedOnLibraryDate;
            NumberOfPages = numberOfPages;
            ISBN = iSBN;
            PublishingHouse = publishingHouse;
            ParutionYear = parutionYear;
        }
    }
}

