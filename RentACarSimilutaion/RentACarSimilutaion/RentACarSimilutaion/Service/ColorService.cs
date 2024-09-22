
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
}
