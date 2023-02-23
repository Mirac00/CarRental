using CarRental.Dtos.DtosForRentals;

namespace CarRental.Dtos.DtosForCars
{
	public class RentalCarDto
	{
		public int Id { get; set; }
		public DateTime StartDate { get; set; }
		public DateTime EndDate { get; set; }
		public double Price { get; set; }
		public RentalClientDto Client { get; set; }
	}
}
