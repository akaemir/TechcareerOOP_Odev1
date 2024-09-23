
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
    ColorRepository colorRepository = new ColorRepository();
    TransmissionRepository transmissionRepository = new TransmissionRepository();
    FuelRepository fuelRepository = new FuelRepository();

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
        var result =
            from c in cars
            join f in fuelRepository.GetAll() on c.FuelId equals f.Id
            join s in colorRepository.GetAll() on c.ColorId equals s.Id
            join t in transmissionRepository.GetAll() on c.TransmissionId equals t.Id

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
        var result =
            from c in cars
            join f in fuelRepository.GetAll() on c.FuelId equals f.Id
            join s in colorRepository.GetAll() on c.ColorId equals s.Id
            join t in transmissionRepository.GetAll() on c.TransmissionId equals t.Id
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
        var result =
            from c in cars
            join f in fuelRepository.GetAll() on c.FuelId equals f.Id
            join s in colorRepository.GetAll() on c.ColorId equals s.Id
            join t in transmissionRepository.GetAll() on c.TransmissionId equals t.Id
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
    public List<CarDetailDTO> GetAllDetailsByPriceRange(double min, double max)
    {
        var result =
            from c in cars
            where c.DailyPrice >= min && c.DailyPrice <= max
            join f in fuelRepository.GetAll() on c.FuelId equals f.Id
            join s in colorRepository.GetAll() on c.ColorId equals s.Id
            join t in transmissionRepository.GetAll() on c.TransmissionId equals t.Id

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
        var result =
            from c in cars
            where c.BrandName.Contains(brandName, StringComparison.InvariantCultureIgnoreCase)
            join f in fuelRepository.GetAll() on c.FuelId equals f.Id
            join s in colorRepository.GetAll() on c.ColorId equals s.Id
            join t in transmissionRepository.GetAll() on c.TransmissionId equals t.Id

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
        List<Fuel> fuels = fuelRepository.GetAll();
        var result =
            from c in cars
            where c.ModelName.Contains(modelName, StringComparison.InvariantCultureIgnoreCase)
            join f in fuelRepository.GetAll() on c.FuelId equals f.Id
            join s in colorRepository.GetAll() on c.ColorId equals s.Id
            join t in transmissionRepository.GetAll() on c.TransmissionId equals t.Id

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

    public List<CarDetailDTO> GetAllDetailsByKilometerRange(int min, int max)
    {
        var result =
            from c in cars
            where c.KiloMeter >= min && c.KiloMeter <= max
            join f in fuelRepository.GetAll() on c.FuelId equals f.Id
            join s in colorRepository.GetAll() on c.ColorId equals s.Id
            join t in transmissionRepository.GetAll() on c.TransmissionId equals t.Id

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
    public CarDetailDTO? GetDetailById(int id)
    {
        var result =
            (from c in cars
             where c.Id == id
             join f in fuelRepository.GetAll() on c.FuelId equals f.Id
             join s in colorRepository.GetAll() on c.ColorId equals s.Id
             join t in transmissionRepository.GetAll() on c.TransmissionId equals t.Id
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
                 )).FirstOrDefault();

        return result;
    }
}
