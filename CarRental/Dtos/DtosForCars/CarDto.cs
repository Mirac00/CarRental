using CarRental.Models;

namespace CarRental.Dtos.DtosForCars
{
	public class CarDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public double DailyPrice { get; set; }
		public List<RentalCarDto> Rentals { get; set; }

	}
}
