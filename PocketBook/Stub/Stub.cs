using Model;
using System.Net;

namespace Stub
{
    public class Stub : ILibraryManager
    {
        private Authors authors { get; set; } = new Authors();
        private Books books { get; set; } = new Books();

        public async Task<IEnumerable<Book>> GetAllBooks() => await  Task.Run(() => books.BookList);

        public Author GetAuthorById(int authorId)
        {
            return (Author)authors.AuthorList.Where(author => author.Id == authorId);        
        }

        public async Task<Book> GetBookById(int bookId) => await  Task.Run(()=> books.BookList.Where(book => book.Id == bookId).First());

        public IEnumerable<Book> GetBooksByAuthor(int authorId)
        {
            return books.BookList.Where(book => book.Authors.Contains(authorId)).ToList();
        }
    }
}