using WebApiDemo.Models;

namespace WebApiDemo.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        Book GetBookById(int id);
 
        int UpdateBook(Book book);
        int DeleteBook(int id);
        int AddBook(Book book);
    }
}
