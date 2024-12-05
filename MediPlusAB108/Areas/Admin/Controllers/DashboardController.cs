using Microsoft.AspNetCore.Mvc;

namespace MediPlusAB108.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
