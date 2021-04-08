using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TrySarahTops.Models;


namespace TrySarahTops.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult LoginPage()
        {
            return View();
        }

        public IActionResult Add(Shirt s)
        {
            return View();
        }
    }
}
