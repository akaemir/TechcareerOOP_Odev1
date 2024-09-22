
using RentACarSimilutaion.ConsoleUI.Models;
using RentACarSimilutaion.ConsoleUI.Models.Dtos;
using System.Xml.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace RentACarSimilutaion.ConsoleUI.Repository;

public class FuelRepository
{
    List<Fuel> fuels = new List<Fuel>()
    {
        new Fuel(1,"Benzin"),
        new Fuel(2,"Dizel"),
        new Fuel(3,"Benzin + LPG"),
        new Fuel(4,"Elektrik"),
        new Fuel(5,"Hibrit"),
    };

    public Fuel? GetById(int id)
    {
        Fuel? fuel_v = null;
        foreach (Fuel fuel in fuels)
        {
            if (fuel.Id == id)
            {
                fuel_v = fuel;
            }
        }
        if (fuel_v == null)
        {
            return null;
        }
        return fuel_v;
    }

    public List<Fuel> GetAll()
    {
        return fuels;
    }

    public Fuel Add(Fuel added)
    {
        fuels.Add(added);
        return added;
    }

    public Fuel? Remove(int id)
    {
        Fuel? deletedFuel = GetById(id);
        if (deletedFuel is null)
        {
            return null;
        }
        fuels.Remove(deletedFuel);
        return deletedFuel;
    }

    
}
