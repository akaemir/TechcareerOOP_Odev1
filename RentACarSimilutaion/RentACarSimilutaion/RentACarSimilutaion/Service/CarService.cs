
using RentACarSimilutaion.ConsoleUI.Models;
using RentACarSimilutaion.ConsoleUI.Models.Dtos;
using RentACarSimilutaion.ConsoleUI.Repository;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using static System.Reflection.Metadata.BlobBuilder;

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

    public void Add(Car car)
    {
        Car added = carRepository.Add(car);
        Console.WriteLine("Araba eklendi.");
        Console.WriteLine(added);
    }
    public void Remove(int id)
    {
        Car? deletedCar = carRepository.Remove(id);
        if (deletedCar is null)
        {
            Console.WriteLine("Aradığnız id'ye göre araç bulunamadı");
            return;
        }
        Console.WriteLine($"Araç silindi : \n{ deletedCar}");
    }
    // UPDATE NEEDED

    public void GetAllDetails()
    {
        List<CarDetailDTO> cars = carRepository.GetAllDetails();
        foreach (CarDetailDTO car in cars)
        {
            Console.WriteLine(car);
        }
    }
    public void GetAllDetailsByFuelId(int fuelId)
    {
        List<CarDetailDTO> cars = carRepository.GetAllDetailsByFuelId(fuelId);
        foreach (CarDetailDTO car in cars)
        {
            Console.WriteLine(car);
        }
    }
    public void GetAllDetailsByColorId(int colorId)
    {
        List<CarDetailDTO> cars = carRepository.GetAllDetailsByColorId(colorId);
        foreach (CarDetailDTO car in cars)
        {
            Console.WriteLine(car);
        }
    }
    public void GetAllDetailsByPriceRange(double min, double max)
    {
        List<CarDetailDTO> cars = carRepository.GetAllDetailsByPriceRange(min,max);
        foreach (CarDetailDTO car in cars)
        {
            Console.WriteLine(car);
        }
    }
    public void GetAllDetailsByBrandNameContains(string brandName)
    {
        List<CarDetailDTO> cars = carRepository.GetAllDetailsByBrandNameContains(brandName);
        foreach (CarDetailDTO car in cars)
        {
            Console.WriteLine(car);
        }
    }
    public void GetAllDetailsByModelNameContains(string modelName)
    {
        List<CarDetailDTO> cars = carRepository.GetAllDetailsByModelNameContains(modelName);
        foreach (CarDetailDTO car in cars)
        {
            Console.WriteLine(car);
        }
    }
    public void GetAllDetailsByKilometerRange(int min, int max)
    {
        List<CarDetailDTO> cars = carRepository.GetAllDetailsByKilometerRange(min,max);
        foreach (CarDetailDTO car in cars)
        {
            Console.WriteLine(car);
        }
    }
    public void GetDetailById(int id)
    {
        CarDetailDTO? car = carRepository.GetDetailById(id);
        if (car is null)
        {
            Console.WriteLine($"Aranan id bulunamadı : {id}");
            return;
        }
        Console.WriteLine(car);
    }
}
