
using RentACarSimilutaion.ConsoleUI.Models;
using RentACarSimilutaion.ConsoleUI.Repository;

namespace RentACarSimilutaion.ConsoleUI.Service;

public class TransmissionService
{
    TransmissionRepository transmissionRepository = new TransmissionRepository();
    public void GetById(int id)
    {
        Transmission? transmission = transmissionRepository.GetById(id);
        if (transmission is null)
        {
            Console.WriteLine($"Aranan id bulunamadı : {id}");
            return;
        }
        Console.WriteLine(transmission);
    }
    public void GetAll()
    {
        List<Transmission> transmissions = transmissionRepository.GetAll();
        transmissions.ForEach(x => Console.WriteLine(x));
    }

    public void Add(Transmission transmission)
    {
        Transmission added = transmissionRepository.Add(transmission);
        Console.WriteLine("Vites tipi eklendi.");
        Console.WriteLine(added);
    }
    public void Remove(int id)
    {
        Transmission? deletedTransmission = transmissionRepository.Remove(id);
        if (deletedTransmission is null)
        {
            Console.WriteLine("Aradığnız id'ye göre vites tipi bulunamadı");
            return;
        }
        Console.WriteLine($"Vites tipi silindi : \n{deletedTransmission}");
    }
    // UPDATE NEEDED
}
