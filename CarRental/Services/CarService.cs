using AutoMapper;
using CarRental.Dtos.DtosForCars;
using CarRental.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Services
{
	public class CarService : ICarService
	{
		private readonly CarRentalDbContext _context;
		private readonly IMapper _mapper;

		public CarService(CarRentalDbContext context, IMapper autoMapper)
		{
			_context = context;
			_mapper = autoMapper;
		}

		public List<CarDto> GetCars()
		{
			var cars = _context.Cars.Include(z => z.Rentals).ToList();
			return _mapper.Map<List<CarDto>>(cars);
		}

		public void AddCar(NewCarDto dto)
		{
			if (dto is not null)
			{
				_context.Add(
					new Car
					{
						Name = dto.Name,
						Description = dto.Description,
						DailyPrice = dto.DailyPrice
					});
				_context.SaveChanges();
			}
		}

		public CarDto GetCarById(int id)
		{
			return _mapper.Map<CarDto>(_context.Cars.FirstOrDefault(c => c.Id == id));
		}

		public void EditCar(int id, NewCarDto car)
		{
			var dbCar = _context.Cars.FirstOrDefault(c => c.Id == id);

			if (dbCar != null)
			{
				dbCar.DailyPrice = car.DailyPrice;
				dbCar.Name = car.Name;
				dbCar.Description = car.Description;
			}
			_context.SaveChanges();
		}

		public void DeleteCar(int id)
		{
			var car = _context.Cars.FirstOrDefault(c => c.Id == id);
			car = null;
			_context.SaveChanges();
		}
	}
}
