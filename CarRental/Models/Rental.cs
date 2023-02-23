namespace CarRental.Models;

public class Rental
{
	public int Id { get; set; }
	public DateTime StartDate { get; set; }
	public DateTime EndDate { get; set; }
	public double Price { get; set; }
	public Car Car { get; set; }
	public Client Client { get; set; }
}
