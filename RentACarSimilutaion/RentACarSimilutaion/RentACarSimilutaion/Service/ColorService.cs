
using RentACarSimilutaion.ConsoleUI.Models;
using RentACarSimilutaion.ConsoleUI.Repository;

namespace RentACarSimilutaion.ConsoleUI.Service;

public class ColorService
{
    ColorRepository colorRepository = new ColorRepository();
    public void GetById(int id)
    {
        Color? color = colorRepository.GetById(id);
        if (color is null)
        {
            Console.WriteLine($"Aranan id bulunamadı : {id}");
            return;
        }
        Console.WriteLine(color);
    }
    public void GetAll()
    {
        List<Color> colors = colorRepository.GetAll();
        colors.ForEach(x => Console.WriteLine(x));
    }
    public void Add(Color color)
    {
        Color added = colorRepository.Add(color);
        Console.WriteLine("Renk eklendi.");
        Console.WriteLine(added);
    }
    public void Remove(int id)
    {
        Color? deletedColor = colorRepository.Remove(id);
        if (deletedColor is null)
        {
            Console.WriteLine("Aradığnız id'ye göre renk bulunamadı");
            return;
        }
        Console.WriteLine($"Renk silindi : \n{deletedColor}");
    }
    // UPDATE NEEDED
}
