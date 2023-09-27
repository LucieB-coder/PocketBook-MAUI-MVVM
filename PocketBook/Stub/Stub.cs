using Model;
using System.Net;

namespace Stub
{
    public class Stub : ILibraryManager
    {
        private Authors authors { get; set; } = new Authors();
        private Books books { get; set; } = new Books();

        public IEnumerable<Book> GetAllBooks()
        {
            return books.BookList;
        }

        public Author GetAuthorById(int authorId)
        {
            return (Author)authors.AuthorList.Where(author => author.Id == authorId);        
        }

        public Book GetBookById(int bookId)
        {
            return (Book)books.BookList.Where(author => author.Id == bookId);
        }

        public IEnumerable<Book> GetBooksByAuthor(int authorId)
        {
            return books.BookList.Where(book => book.Authors.Contains(authorId)).ToList();
        }
    }
}