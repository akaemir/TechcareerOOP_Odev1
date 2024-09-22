
using RentACarSimilutaion.ConsoleUI.Models;
using RentACarSimilutaion.ConsoleUI.Repository;

namespace RentACarSimilutaion.ConsoleUI.Service;

public class CarService
{
    CarRepository carRepository = new CarRepository();
    public void GetById(int id)
    {
        Car? car = carRepository.GetById(id);
        if (car is null)
        {
            Console.WriteLine($"Aranan id bulunamadı : {id}");
            return;
        }
        Console.WriteLine(car);
    }
    public void GetAll()
    {
        List<Car> cars = carRepository.GetAll();
        cars.ForEach(x => Console.WriteLine(x));
    }
}
