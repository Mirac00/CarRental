using CarRental.Dtos.DtosForCars;
using CarRental.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
	public class NewCarController : Controller
	{
		private readonly ICarService _carService;

		public NewCarController(ICarService carService)
		{
			_carService = carService;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public IActionResult AddCar(NewCarDto dto)
		{
			if (ModelState.IsValid)
			{
				_carService.AddCar(dto);
			}

			return View("Index");
		}
	}
}
