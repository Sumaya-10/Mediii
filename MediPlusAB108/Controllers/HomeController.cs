
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MediPlusAB108.Controllers
{
    public class HomeController : Controller
    {
    
        public IActionResult Index()
        {
            return View();
        }

    }
}
