using CarRental.Dtos.DtosForRentals;

namespace CarRental.Services
{
    public interface IRentalService
    {
        List<RentalDto> GetAll();
    }
}