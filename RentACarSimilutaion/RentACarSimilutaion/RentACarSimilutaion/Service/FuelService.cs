
using RentACarSimilutaion.ConsoleUI.Models;
using RentACarSimilutaion.ConsoleUI.Repository;

namespace RentACarSimilutaion.ConsoleUI.Service;

public class FuelService
{
    FuelRepository fuelRepository = new FuelRepository();
    public void GetById(int id)
    {
        Fuel? fuel = fuelRepository.GetById(id);
        if (fuel is null)
        {
            Console.WriteLine($"Aranan id bulunamadı : {id}");
            return;
        }
        Console.WriteLine(fuel);
    }
    public void GetAll()
    {
        List<Fuel> fuels = fuelRepository.GetAll();
        fuels.ForEach(x => Console.WriteLine(x));
    }

    public void Add(Fuel fuel)
    {
        Fuel added = fuelRepository.Add(fuel);
        Console.WriteLine("Yakıt tipi eklendi.");
        Console.WriteLine(added);
    }
    public void Remove(int id)
    {
        Fuel? deletedFuel = fuelRepository.Remove(id);
        if (deletedFuel is null)
        {
            Console.WriteLine("Aradığnız id'ye göre yakıt tipi bulunamadı");
            return;
        }
        Console.WriteLine($"Yakıt tipi silindi : \n{deletedFuel}");
    }
    // UPDATE NEEDED
}
