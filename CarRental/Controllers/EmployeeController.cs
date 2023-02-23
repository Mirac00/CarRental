using CarRental.Dtos;
using CarRental.Models;
using CarRental.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarRental.Controllers
{
	public class EmployeeController : Controller
	{
		private readonly ILoginService _loginService;

		public EmployeeController(ILoginService loginService)
		{
			_loginService = loginService;
		}

		public IActionResult Index()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Login(EmployeeLoginDto employee)
		{
			if (ModelState.IsValid)
			{
				if (_loginService.Login(employee))
					return RedirectToAction("Index", "Rental");
			}

			return View("Index");
		}
	}
}
