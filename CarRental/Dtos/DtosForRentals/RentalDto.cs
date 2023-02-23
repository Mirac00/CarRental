using CarRental.Models;

namespace CarRental.Dtos.DtosForRentals;

public class RentalDto
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public double Price { get; set; }
    public CarRentalDto Car { get; set; }
    public RentalClientDto Client { get; set; }
}
