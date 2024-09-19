
using LibraryManagement.ConsoleUI.Models;
using LibraryManagement.ConsoleUI.Repository;

namespace LibraryManagement.ConsoleUI.Service;

public class BookService
{
    BookRepository bookRepository = new BookRepository();

    public void GetAll()
    {
        List<Book> books = bookRepository.GetAll();
        foreach (Book book in books) 
        {
            Console.WriteLine(book);
        }
    }

    public void GetByID(int id)
    {
        Book? book = bookRepository.GetByID(id);
        if (book is null)
        {
            Console.WriteLine($"Aradığınız id'ye göre kitap bulunamadı : {id}");
            return;
        }

        Console.WriteLine(book);
    }

    public void Remove(int id) 
    {
        Book? deletedBook = bookRepository.Remove(id);
        if (deletedBook is null) 
        {
            Console.WriteLine("Aradığnız kitab bulunamadı (Zeten Yok)");
            return;
        }
        Console.WriteLine(deletedBook);
    }

    public void GetBookByISBN(string isbn)
    {
        Book? book = bookRepository.GetBookByISBN(isbn);
        if (book is null)
        {
            Console.WriteLine($"Aradığınız ISBN numarasına göre kitap bulunamadı. {isbn}");
            return;
        }
        Console.WriteLine(book);
    }
}
