
using LibraryManagement.ConsoleUI.Models;
using LibraryManagement.ConsoleUI.Repository;

namespace LibraryManagement.ConsoleUI.Service;

public class CategoryService
{
    CategoryRepository categoryRepository = new CategoryRepository();

    public void GetAllCategorys()
    {
        List<Category> categories = categoryRepository.GetAllCategory();
        foreach (Category category in categories)
        {
            Console.WriteLine(category);
        }
    }

    public void GetCategoryById(int id)
    {
        Category? category = categoryRepository.GetCategoryById(id);
        if (category is null)
        {
            Console.WriteLine($"Aradığınız id'ye göre kategori bulunamadı : {id}");
            return;
        }
        Console.WriteLine(category);
    }
    public void GetCategoryByName(string name)
    {
        List<Category> categories = categoryRepository.GetCategoryByName(name);
        foreach (Category category in categories)
        {
            Console.WriteLine(category);
        }
    }
}
