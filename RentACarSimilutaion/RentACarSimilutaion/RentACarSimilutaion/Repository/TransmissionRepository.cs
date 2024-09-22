

using RentACarSimilutaion.ConsoleUI.Models;
using System.Xml.Linq;

namespace RentACarSimilutaion.ConsoleUI.Repository;

public class TransmissionRepository
{
    List<Transmission> transmissions = new List<Transmission>()
    {
        new Transmission(1,"Manuel"),
        new Transmission(2,"Otomatik"),
    };

    public Transmission? GetById(int id)
    {
        Transmission? transmission_v = null;
        foreach (Transmission transmission in transmissions)
        {
            if (transmission_v.Id == id)
            {
                transmission_v = transmission;
            }
        }
        if (transmission_v == null)
        {
            return null;
        }
        return transmission_v;
    }

    public List<Transmission> GetAll()
    {
        return transmissions;
    }

    public Transmission Add(Transmission added)
    {
        transmissions.Add(added);
        return added;
    }

    public Transmission? Remove(int id)
    {
        Transmission? deletedTransmission = GetById(id);
        if (deletedTransmission is null)
        {
            return null;
        }
        transmissions.Remove(deletedTransmission);
        return deletedTransmission;
    }
}
