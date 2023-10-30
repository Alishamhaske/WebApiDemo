using WebApiDemo.Models;
using WebApiDemo.Repositories;

namespace WebApiDemo.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository repo;
        public BookService(IBookRepository repo)
        {
            this.repo = repo;
        }

        int IBookService.AddBook(Book book)
        {
            return repo.AddBook(book);
        }

     

        int IBookService.DeleteBook(int id)
        {
            return repo.DeleteBook(id);
        }

        Book IBookService.GetBookById(int id)
        {
            return repo.GetBookById(id);
        }

        IEnumerable<Book> IBookService.GetBooks()
        {
            return repo.GetBooks();
        }

        int IBookService.UpdateBook(Book book)
        {
            return repo.UpdateBook(book);
        }

    }
}
