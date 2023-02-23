using CarRental.Dtos.DtosForCars;
using CarRental.Models;
using Microsoft.EntityFrameworkCore;

namespace CarRental.Services
{
    public interface ICarService
	{
		List<CarDto> GetCars();

		void AddCar(NewCarDto dto);

		CarDto GetCarById(int id);

		void EditCar(int id, NewCarDto car);

		void DeleteCar(int id);
	}
}