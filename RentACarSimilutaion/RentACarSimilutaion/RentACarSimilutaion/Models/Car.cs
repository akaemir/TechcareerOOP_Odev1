namespace RentACarSimilutaion.ConsoleUI.Models;

public record Car(
int Id,
int ColorId,
int FuelId,
int TransmissionId,
string CarState,
int? KiloMeter,
short? ModelYear,
string? Plate,
string? BrandName,
string? ModelName,
double? DailyPrice
)
{
    public override string ToString()
    {
        return $"Araç id'si : {Id}, Araç renk kodu: {ColorId}, Yakıt tipi : {FuelId}, Vites tipi : {TransmissionId}, Araç durumu : {CarState}, Kilometresi : {KiloMeter}, Model yılı : {ModelYear}, Plakası : {Plate}, Marka : {BrandName}, Model : {ModelName}, Günlük ücreti : {DailyPrice}";
    }

}