using Model;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Stub
{
    public class Stub : ILibraryManager, IUserLibraryManager
    {
        private Books books { get; set; } = new Books();

        private Lends lends { get; set; } = new Lends();

        private List<Book> Favorites = new List<Book>();

        public async Task<IEnumerable<Book>> GetAllBooks() => await Task.Run(() => books.BookList);

        public Task<IEnumerable<Lend>> GetAllLends()
        {
            throw new NotImplementedException();
        }

        public async Task<Book> GetBookById(int bookId) 
        {
            return await Task.Run(() => FindBookByID(bookId));
        }

        public async Task<IEnumerable<Lend>> GetBorrows()
        {
            return await Task.Run(() => lends.borrows);
        }

        public async Task<IEnumerable<Lend>> GetLends()
        {
            return await Task.Run(() => lends.lends);
        }

        public async void AddBookToFavorites(Book book)
        {
            await Task.Run(()=> Favorites.Add(book));
        }

        public async Task<IEnumerable<Book>> GetFavorites()
        {
            return await Task.Run(() => Favorites);
        }

        private Book FindBookByID(int bookId)
        {
            Book book = books.BookList.First(book=> book.Id == bookId);
            return book;
        }

    }
}