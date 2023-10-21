using Model;
using System.Net;

namespace Stub
{
    public class Stub : ILibraryManager
    {
        private Books books { get; set; } = new Books();

        public async Task<IEnumerable<Book>> GetAllBooks() => await Task.Run(() => books.BookList);

        public async Task<Book> GetBookById(int bookId) 
        {
            return await Task.Run(() => FindBookByID(bookId));
        }

        private Book FindBookByID(int bookId)
        {
            Book book = books.BookList.First(book=> book.Id == bookId);
            return book;
        }

    }
}