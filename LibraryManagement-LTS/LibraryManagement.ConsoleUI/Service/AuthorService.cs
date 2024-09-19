
using LibraryManagement.ConsoleUI.Models;
using LibraryManagement.ConsoleUI.Repository;

namespace LibraryManagement.ConsoleUI.Service;

public class AuthorService
{
    AuthorRepository authorRepository = new AuthorRepository();

    public void GetAllAuthors()
    {
        List<Author> authors = authorRepository.GetAllAuthors();
        foreach (Author author in authors)
        {
            Console.WriteLine(author);
        }
    }

    public void GetAuthorById(int id) 
    {
        Author? author = authorRepository.GetAuthorById(id);
        if (author is null)
        {
            Console.WriteLine($"Aradığınız id'ye göre yazar bulunamadı : {id}");
            return;
        }
        Console.WriteLine(author);
    }
    public void GetAuthorByName(string name) 
    {
        List<Author> authors = authorRepository.GetAuthorByName(name);
        foreach (Author author in authors)
        {
            Console.WriteLine(author);
        }
    }
}
