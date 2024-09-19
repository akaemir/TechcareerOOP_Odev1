using LibraryManagement.ConsoleUI.Models;

namespace LibraryManagement.ConsoleUI.Repository;

public class BookRepository
{
    List<Book> books = new List<Book>()
{
    new Book(1,"Germinal","Kömür Madeni",341,"2012 Mayıs","9781234567897"),
    new Book(2,"Suç ve Ceza","Raskolnikov un hayatı",315,"2010 Haziran","9781234567891"),
    new Book(3,"Kumarbaz","Bir Öğretmenin hayatı",210,"2009 Ocak","9781234567892"),
    new Book(4, "Araba Sevdası","Arabayla alakası olmayan Kitap",180,"1999 Ocak","9781234567838"),
    new Book(5,"Ateşten Gömlek","Kurtulu savaşını anlatan kitap",120,"2001 Eylül","9781234567834"),
    new Book(6,"Kaşağı","Okunmaması gereken bir kitap",95,"1993 Ocak","9781234567845"),
    new Book(7,"28 Şampiyonluk","Hayal ürünüdür",350,"1907 Ocak ","9781234567807"),
    new Book(8,"16 Yıl Şampiyonluk","Hayal ürünüdür.",255,"10 Eylül","9781234567800"),
    new Book(9,"Ali Arı","Uyanık Ceo nun hikayesi",551,"20 Haziran","9781234567803")
};


    public List<Book> GetAll()
    {
        return books;
    }

    public List<Book> GetAllBooksByPageSizeFilter(int min, int max)
    {
        List<Book> filteredBooks = new List<Book>();

        foreach (Book book in books)
        {
            if (book.PageSize <= max && book.PageSize >= min)
            {
                filteredBooks.Add(book);
            }
        }
        return filteredBooks;
    }

    public double PageSizeTotalCalculator()
    {
        double total = books.Sum(x => x.PageSize);
        return total;
    }

    public List<Book> GetAllBooksByTitleContains(string text)
    {
        List<Book> filteredBooksText = new List<Book>();
        foreach (Book book in books)
        {
            if (book.Title.Contains(text, StringComparison.InvariantCultureIgnoreCase))
            {
                filteredBooksText.Add(book);
            }
        }
        return filteredBooksText;
    }
    public Book? GetBookByISBN(string isbn)
    {
        Book? book1 = null; // new 

        foreach (Book item in books)
        {
            if (item.ISBN == isbn)
            {
                book1 = item;
                break;
            }
        }
        //return book1 == null ? null : book1;
        //return book1 is not null ? book1: null;
        if (book1 == null)
        {
            return null;
        }
        return book1;
    }

    public Book Add(Book created)
    {
        books.Add(created);
        return created;
    }

    public Book? GetByID(int id)
    {
        Book? book1 = null;
        foreach (Book book in books)
        {
            if (book.Id == id)
            {
                book1 = book;

            }
        }
        if (book1 == null)
        {
            return null;
        }
        return book1;
    }

    public Book? Remove(int id)
    {
        Book? deletedBook = GetByID(id);
        if (deletedBook is null)
        {
            return null;
        }
        books.Remove(deletedBook);
        return deletedBook;
    }
}
