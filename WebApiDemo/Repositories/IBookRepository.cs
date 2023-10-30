using WebApiDemo.Models;

namespace WebApiDemo.Repositories
{
    public interface IBookRepository
    {

        IEnumerable<Book> GetBooks();
        Book GetBookById(int id);

        int UpdateBook(Book book);
        int DeleteBook(int id);
        int AddBook(Book book);
    }
}
