using Microsoft.Build.Framework;

namespace CarRental.Models;

public class Employee
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string LastName { get; set; }
	[Required]
	public string Login { get; set; }
	[Required]
	public string Password { get; set; }
}
