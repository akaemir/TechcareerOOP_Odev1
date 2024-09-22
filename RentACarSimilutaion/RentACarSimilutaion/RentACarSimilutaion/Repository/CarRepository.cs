
using RentACarSimilutaion.ConsoleUI.Models;
using RentACarSimilutaion.ConsoleUI.Models.Dtos;
using static System.Reflection.Metadata.BlobBuilder;

namespace RentACarSimilutaion.ConsoleUI.Repository;

public class CarRepository
{

    List<Car> cars = new List<Car>()
    {
        new Car(1,1,1,2,"Rental",76000,2017,"34 PLT 34","Land Rover","Range Rover",10000),
        new Car(2,4,1,2,"Rental",48960,2022,"34 BZ4 53","BMW","Z4",15000),
        new Car(3,1,5,2,"Rental",67896,2021,"34 BI8 41","BMW","i8 hybrid",12000),
        new Car(4,2,5,2,"Rental",67896,2021,"34 BI8 41","BMW","i8 hybrid",12000),
        new Car(5,3,1,1,"Rental",24166,2022,"34 CL5 54","Renault","Clio 5",805),
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

    public Car Add(Car added)
    {
        cars.Add(added);
        return added;
    }

    public Car? Remove(int id)
    {
        Car? deletedCar = GetById(id);
        if (deletedCar is null)
        {
            return null;
        }
        cars.Remove(deletedCar);
        return deletedCar;
    }
    // UPDATE NEEDED

    public List<CarDetailDTO> GetAllDetails()
    {
        CarRepository carRepository = new CarRepository();
        List<Car> cars = carRepository.GetAll();
        ColorRepository colorRepository = new ColorRepository();
        List<Color> colors = colorRepository.GetAll();
        TransmissionRepository transmissionRepository = new TransmissionRepository();
        List<Transmission> transmissions = transmissionRepository.GetAll();
        FuelRepository fuelRepository = new FuelRepository();
        List<Fuel> fuels = fuelRepository.GetAll();
        var result =
            from c in cars
            join f in fuels on c.FuelId equals f.Id
            join s in colors on c.ColorId equals s.Id
            join t in transmissions on c.TransmissionId equals t.Id

            select new CarDetailDTO(
                Id: c.Id,
                FuelName: f.Name,
                TransmissionName: t.Name,
                ColorName: s.Name,
                CarState: c.CarState,
                KiloMeter: c.KiloMeter,
                ModelYear: c.ModelYear,
                Plate: c.Plate,
                BrandName: c.BrandName,
                ModelName: c.ModelName,
                DailyPrice: c.DailyPrice
                );

        return result.ToList();
    }
    public List<CarDetailDTO> GetAllDetailsByFuelId(int fuelId)
    {
        CarRepository carRepository = new CarRepository();
        List<Car> cars = carRepository.GetAll();
        ColorRepository colorRepository = new ColorRepository();
        List<Color> colors = colorRepository.GetAll();
        TransmissionRepository transmissionRepository = new TransmissionRepository();
        List<Transmission> transmissions = transmissionRepository.GetAll();
        FuelRepository fuelRepository = new FuelRepository();
        List<Fuel> fuels = fuelRepository.GetAll();
        var result =
            from c in cars 
            join f in fuels on c.FuelId equals f.Id
            join s in colors on c.ColorId equals s.Id
            join t in transmissions on c.TransmissionId equals t.Id
            where f.Id == fuelId

            select new CarDetailDTO(
                Id: c.Id,
                FuelName: f.Name,
                TransmissionName: t.Name,
                ColorName: s.Name,
                CarState: c.CarState,
                KiloMeter: c.KiloMeter,
                ModelYear: c.ModelYear,
                Plate: c.Plate,
                BrandName: c.BrandName,
                ModelName: c.ModelName,
                DailyPrice: c.DailyPrice
                );

        return result.ToList();
    }
    public List<CarDetailDTO> GetAllDetailsByColorId(int colorId)
    {
        CarRepository carRepository = new CarRepository();
        List<Car> cars = carRepository.GetAll();
        ColorRepository colorRepository = new ColorRepository();
        List<Color> colors = colorRepository.GetAll();
        TransmissionRepository transmissionRepository = new TransmissionRepository();
        List<Transmission> transmissions = transmissionRepository.GetAll();
        FuelRepository fuelRepository = new FuelRepository();
        List<Fuel> fuels = fuelRepository.GetAll();
        var result =
            from c in cars
            join f in fuels on c.FuelId equals f.Id
            join s in colors on c.ColorId equals s.Id
            join t in transmissions on c.TransmissionId equals t.Id
            where s.Id == colorId

            select new CarDetailDTO(
                Id: c.Id,
                FuelName: f.Name,
                TransmissionName: t.Name,
                ColorName: s.Name,
                CarState: c.CarState,
                KiloMeter: c.KiloMeter,
                ModelYear: c.ModelYear,
                Plate: c.Plate,
                BrandName: c.BrandName,
                ModelName: c.ModelName,
                DailyPrice: c.DailyPrice
                );

        return result.ToList();
    }
    public List<CarDetailDTO> GetAllDetailsByPriceRange(double min,double max)
    {
        CarRepository carRepository = new CarRepository();
        List<Car> cars = carRepository.GetAll();
        ColorRepository colorRepository = new ColorRepository();
        List<Color> colors = colorRepository.GetAll();
        TransmissionRepository transmissionRepository = new TransmissionRepository();
        List<Transmission> transmissions = transmissionRepository.GetAll();
        FuelRepository fuelRepository = new FuelRepository();
        List<Fuel> fuels = fuelRepository.GetAll();
        var result =
            from c in cars where c.DailyPrice >= min && c.DailyPrice <= max 
            join f in fuels on c.FuelId equals f.Id
            join s in colors on c.ColorId equals s.Id
            join t in transmissions on c.TransmissionId equals t.Id

            select new CarDetailDTO(
                Id: c.Id,
                FuelName: f.Name,
                TransmissionName: t.Name,
                ColorName: s.Name,
                CarState: c.CarState,
                KiloMeter: c.KiloMeter,
                ModelYear: c.ModelYear,
                Plate: c.Plate,
                BrandName: c.BrandName,
                ModelName: c.ModelName,
                DailyPrice: c.DailyPrice
                );

        return result.ToList();
    }
    public List<CarDetailDTO> GetAllDetailsByBrandNameContains(string brandName)
    {
        CarRepository carRepository = new CarRepository();
        List<Car> cars = carRepository.GetAll();
        ColorRepository colorRepository = new ColorRepository();
        List<Color> colors = colorRepository.GetAll();
        TransmissionRepository transmissionRepository = new TransmissionRepository();
        List<Transmission> transmissions = transmissionRepository.GetAll();
        FuelRepository fuelRepository = new FuelRepository();
        List<Fuel> fuels = fuelRepository.GetAll();
        var result =
            from c in cars where c.BrandName.Contains(brandName,StringComparison.InvariantCultureIgnoreCase)
            join f in fuels on c.FuelId equals f.Id
            join s in colors on c.ColorId equals s.Id
            join t in transmissions on c.TransmissionId equals t.Id

            select new CarDetailDTO(
                Id: c.Id,
                FuelName: f.Name,
                TransmissionName: t.Name,
                ColorName: s.Name,
                CarState: c.CarState,
                KiloMeter: c.KiloMeter,
                ModelYear: c.ModelYear,
                Plate: c.Plate,
                BrandName: c.BrandName,
                ModelName: c.ModelName,
                DailyPrice: c.DailyPrice
                );

        return result.ToList();
    }
    public List<CarDetailDTO> GetAllDetailsByModelNameContains(string modelName)
    {
        CarRepository carRepository = new CarRepository();
        List<Car> cars = carRepository.GetAll();
        ColorRepository colorRepository = new ColorRepository();
        List<Color> colors = colorRepository.GetAll();
        TransmissionRepository transmissionRepository = new TransmissionRepository();
        List<Transmission> transmissions = transmissionRepository.GetAll();
        FuelRepository fuelRepository = new FuelRepository();
        List<Fuel> fuels = fuelRepository.GetAll();
        var result =
            from c in cars where c.ModelName.Contains(modelName, StringComparison.InvariantCultureIgnoreCase)
            join f in fuels on c.FuelId equals f.Id
            join s in colors on c.ColorId equals s.Id
            join t in transmissions on c.TransmissionId equals t.Id

            select new CarDetailDTO(
                Id: c.Id,
                FuelName: f.Name,
                TransmissionName: t.Name,
                ColorName: s.Name,
                CarState: c.CarState,
                KiloMeter: c.KiloMeter,
                ModelYear: c.ModelYear,
                Plate: c.Plate,
                BrandName: c.BrandName,
                ModelName: c.ModelName,
                DailyPrice: c.DailyPrice
                );

        return result.ToList();
    }
    



}
