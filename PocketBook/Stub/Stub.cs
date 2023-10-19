using Model;
using System.Net;

namespace Stub
{
    public class Stub : ILibraryManager
    {
        private Books books { get; set; } = new Books();

        public async Task<IEnumerable<Book>> GetAllBooks() => await Task.Run(() => books.BookList);

        public async Task<Book> GetBookById(int bookId) => await  Task.Run(()=> books.BookList.Where(book => book.Id == bookId).First());

    }
}