
using LibraryManagement.ConsoleUI.Models;

namespace LibraryManagement.ConsoleUI.Repository;

public class CategoryRepository
{
    List<Category> categories = new List<Category>()
    {
    new Category(1,"Dünya Klasikleri"),
    new Category(2,"Türk Klasikleri"),
    new Category(3,"Bilim Kurgu")
    };

    public List<Category> GetAllCategory()
    {
        return categories;
    }
    public Category? GetCategoryById(int id)
    {
        Category? category1 = null;
        foreach (Category Category in categories)
        {
            if (Category.Id == id)
            {
                category1 = Category;

            }
        }
        if (category1 == null)
        {
            return null;
        }
        return category1;
    }
    public List<Category> GetCategoryByName(string text)
    {
        List<Category> filteredCategoryText = new List<Category>();
        foreach (Category category in categories)
        {
            if (category.Name.Contains(text, StringComparison.InvariantCultureIgnoreCase))
            {
                filteredCategoryText.Add(category);
            }
        }
        return filteredCategoryText;
    }

}
