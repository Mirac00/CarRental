using AutoMapper;
using CarRental.Dtos.DtosForRentals;
using CarRental.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Services
{
    public class RentalService : IRentalService
	{
		private readonly CarRentalDbContext _dbContext;
		private readonly IMapper _autoMapper;

		public RentalService(CarRentalDbContext dbContext, IMapper autoMapper)
		{
			_dbContext = dbContext;
			_autoMapper = autoMapper;
		}

		public List<RentalDto> GetAll()
		{
			var rents = _dbContext.Rents.Include(c => c.Client).Include(c => c.Car);

			return _autoMapper.Map<List<RentalDto>>(rents);
		}
	}
}
