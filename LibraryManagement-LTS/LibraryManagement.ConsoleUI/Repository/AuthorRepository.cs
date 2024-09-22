
using LibraryManagement.ConsoleUI.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagement.ConsoleUI.Repository;

public class AuthorRepository
{
    List<Author> authors = new List<Author>()
{
    new Author(1,"Emile","Zola"),
    new Author(2,"Fyodor","Dostoyevski"),
    new Author(3,"Recaizade Mahmut","Ekrem"),
    new Author(4, "Halide Edib","Adıvar"),
    new Author(5,"Ömer","Seyfettin"),
    new Author(6,"Ali","Koç"),
    new Author(7,"Vız vız","Ali"),
};

    public List<Author> GetAllAuthors()
    {
        return authors;
    }
    public Author? GetAuthorById(int id)
    {
        Author? author1 = null;
        foreach (Author author in authors)
        {
            if (author.Id == id)
            {
                author1 = author;

            }
        }
        if (author1 == null)
        {
            return null;
        }
        return author1;
    }
    public List<Author> GetAuthorByName(string text)
    {
        List<Author> filteredAuthorText = new List<Author>();
        foreach (Author author in authors)
        {
            if (author.Name.Contains(text, StringComparison.InvariantCultureIgnoreCase))
            {
                filteredAuthorText.Add(author);
            }
        }
        return filteredAuthorText;
    }
}
