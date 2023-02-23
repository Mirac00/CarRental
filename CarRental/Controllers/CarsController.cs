using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRental.Models;
using CarRental.Services;
using CarRental.Dtos.DtosForCars;

namespace CarRental.Controllers
{
    [Route("api/[controller]")]
	[ApiController]
	public class CarsController : ControllerBase
	{
		private readonly ICarService _carService;

		public CarsController(ICarService carService)
		{
			_carService = carService;
		}

		// GET: api/Cars
		[HttpGet]
		public ActionResult<IEnumerable<CarDto>> GetCars()
		{
			return Ok(_carService.GetCars());
		}

		// GET: api/Cars/5
		[HttpGet("{id}")]
		public ActionResult<CarDto> GetCar(int id)
		{
			var car = _carService.GetCarById(id);

			if (car == null)
			{
				return NotFound();
			}

			return car;
		}

		// PUT: api/Cars/5
		[HttpPut("{id}")]
		public IActionResult PutCar(int id, NewCarDto car)
		{
			_carService.EditCar(id, car);

			return NoContent();
		}

		// POST: api/Cars
		[HttpPost]
		public ActionResult<CarDto> PostCar(NewCarDto car)
		{
			_carService.AddCar(car);

			return Created("", car);
		}

		// DELETE: api/Cars/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCar(int id)
		{
			_carService.DeleteCar(id);

			return NoContent();
		}
	}
}
