
using RentACarSimilutaion.ConsoleUI.Models;

namespace RentACarSimilutaion.ConsoleUI.Repository;

public class ColorRepository
{
    List<Color> colors = new List<Color>()
    {
        new Color(1,"Beyaz"),
        new Color(2,"Siyah"),
        new Color(3,"Kırmızı"),
        new Color(4,"Mavi"),
        new Color(5,"Sarı"),
        new Color(6,"Gri"),
        new Color(7,"Magenta"),
        new Color(8,"Mor"),
    };

    public Color? GetById(int id)
    {
        Color? color_v = null;
        foreach (Color color in colors)
        {
            if (color.Id == id)
            {
                color_v = color;
            }
        }
        if (color_v == null)
        {
            return null;
        }
        return color_v;
    }

    public List<Color> GetAll()
    {
        return colors;
    }
    public Color Add(Color added)
    {
        colors.Add(added);
        return added;
    }

    public Color? Remove(int id)
    {
        Color? deletedColor = GetById(id);
        if (deletedColor is null)
        {
            return null;
        }
        colors.Remove(deletedColor);
        return deletedColor;
    }
}
