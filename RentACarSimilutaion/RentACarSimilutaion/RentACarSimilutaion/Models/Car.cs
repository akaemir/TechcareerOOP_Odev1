namespace RentACarSimilutaion.ConsoleUI.Models;

public class Car
{

    public Car(int id, int colorId, int fuelId, int transmissionId, string carState, int? kiloMeter, short? modelYear, string? plate, string? brandName, string? modelName, double? dailyPrice)
    {
        Id = id;
        ColorId = colorId;
        FuelId = fuelId;
        TransmissionId = transmissionId;
        ModelYear = modelYear;
        Plate = plate;
        BrandName = brandName;
        ModelName = modelName;
        DailyPrice = dailyPrice;
        CarState = carState;
        KiloMeter = kiloMeter;
    }
    public int Id { get; set; }
    public int ColorId { get; set; }
    public int FuelId { get; set; }
    public int TransmissionId { get; set; }
    public string CarState { get; set; }
    public int? KiloMeter { get; set; }
    public short? ModelYear { get; set; }
    public string? Plate { get; set; }
    public string? BrandName { get; set; }
    public string? ModelName { get; set; }
    public double? DailyPrice { get; set; }

    

    //public record Car(
    //int Id,
    //int ColorId,
    //int FuelId,
    //int TransmissionId,
    //string CarState,
    //int? KiloMeter,
    //short? ModelYear,
    //string? Plate,
    //string? BrandName,
    //string? ModelName,
    //double? DailyPrice
    //)
    public override string ToString()
    {
        return $"Araç id'si : {Id}, Araç renk kodu: {ColorId}, Yakıt tipi : {FuelId}, Vites tipi : {TransmissionId}, Araç durumu : {CarState}, Kilometresi : {KiloMeter}, Model yılı : {ModelYear}, Plakası : {Plate}, Marka : {BrandName}, Model : {ModelName}, Günlük ücreti : {DailyPrice}";
    }

}