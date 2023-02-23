using CarRental.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
    public class RentalController : Controller
	{
		private readonly IRentalService _rentalService;

		public RentalController(IRentalService rentalService)
		{
			_rentalService = rentalService;
		}
		public IActionResult Index()
		{
			var rentals = _rentalService.GetAll();

			return View(rentals);
		}
	}
}
