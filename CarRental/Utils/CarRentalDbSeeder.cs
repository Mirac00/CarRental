using CarRental.Models;
using System.Linq;

namespace CarRental.Utils;

public class CarRentalDbSeeder
{
	private readonly CarRentalDbContext _context;

	public CarRentalDbSeeder(CarRentalDbContext context)
	{
		_context = context;
	}

	public void Seed()
	{
		if (!_context.Clients.Any())
		{
			_context.Clients.AddRange(GetClients());
			_context.SaveChanges();
		}

		if (!_context.Cars.Any())
		{
			_context.Cars.AddRange(GetCars());
			_context.SaveChanges();
		}

		if (!_context.Rents.Any())
		{
			_context.Rents.AddRange(
				new List<Rental>
				{
					new Rental
					{
						Car = _context.Cars.First(),
						Client = _context.Clients.First(),
						StartDate = new DateTime(2022,10,20),
						EndDate = new DateTime(2022,10,22),
						Price = 26000.38
					},
					new Rental
					{
						Car = _context.Cars.FirstOrDefault(x=>x.Id==2),
						Client = _context.Clients.First(),
						StartDate = new DateTime(2022,11,20),
						EndDate = new DateTime(2022,12,22),
						Price = 120.00
					}
				});
			_context.SaveChanges();
		}

		if (!_context.Employers.Any())
		{
			_context.Employers.Add(
				new Employee
				{
					Name = "admin",
					LastName = "admin",
					Login = "admin",
					Password = "admin"
				});
			_context.SaveChanges();
		}
	}

	private List<Car> GetCars()
	{
		return new List<Car>
		{
			new Car
			{
				Name = "Daewoo Matiz",
				Description = "Super luxurious, rare daewoo matiz",
				DailyPrice = 13000.19
			},
			new Car
			{
				Name = "Daewoo Lanos",
				Description = "Super cheap, rare daewoo Lanos",
				DailyPrice = 190.10
			},
			new Car
			{
				Name = "Mercedes w126",
				Description = "Affordable, Mercedes w126",
				DailyPrice = 10,
			},
		};
	}

	private List<Client> GetClients()
	{
		return new List<Client>
		{
			new Client
			{
				Email = "john@example.com",
				Name = "John",
				LastName = "Smith"
			},
		};
	}
}
