using Microsoft.Build.Framework;

namespace CarRental.Models;

public class Client
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string LastName { get; set; }
	public string Email { get; set; }
	public List<Rental> Rentals { get; set; }
}
