using Microsoft.EntityFrameworkCore;
using CarRental.Dtos.DtosForRentals;

namespace CarRental.Models;

public class CarRentalDbContext : DbContext
{
	protected readonly IConfiguration Configuration;

	public CarRentalDbContext(IConfiguration configuration)
	{
		Configuration = configuration;
	}
	public CarRentalDbContext()
	{

	}

	protected override void OnConfiguring(DbContextOptionsBuilder options)
	{
		options.UseSqlite(Configuration.GetConnectionString("CarRentalDatabase"));
	}

	public virtual DbSet<Car> Cars { get; set; }
	public virtual DbSet<Client> Clients { get; set; }
	public virtual DbSet<Rental> Rents { get; set; }
	public virtual DbSet<Employee> Employers { get; set; }
}
