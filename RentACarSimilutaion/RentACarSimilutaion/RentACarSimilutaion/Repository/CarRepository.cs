
using RentACarSimilutaion.ConsoleUI.Models;

namespace RentACarSimilutaion.ConsoleUI.Repository;

public class CarRepository
{
    List<Car> cars = new List<Car>()
    {
        new Car(1,1,1,1,"Rental",76000,2017,"34 PLT 34","Land Rover","Range Rover",10000),
        new Car(2,1,1,1,"Rental",48960,2022,"34 BZ4 53","BMW","Z4",15000),
        new Car(3,1,1,1,"Rental",67896,2021,"34 BI8 41","BMW","i8 hybrid",12000),
    };

    public Car? GetById(int id)
    {
        Car? car_v = null;
        foreach (Car car in cars)
        {
            if (car.Id == id)
            {
                car_v = car;
            }
        }
        if (car_v == null)
        {
            return null;
        }
        return car_v;
    }

    public List<Car> GetAll() 
    {
        return cars;
    }
}
