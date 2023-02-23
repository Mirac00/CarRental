namespace CarRental.Models;

public class Car
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	public double DailyPrice { get; set; }
	public List<Rental> Rentals { get; set; }

}
