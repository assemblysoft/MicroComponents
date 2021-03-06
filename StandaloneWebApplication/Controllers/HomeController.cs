using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StandaloneWebApplication.Models;
using System.Diagnostics;

namespace StandaloneWebApplication.Controllers
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

        public IActionResult WeatherForecastAppView()
        {
            return View();         
        }

        public IActionResult WeatherForecastAppViewPartial()
        {
            return PartialView("WeatherForecastAppView");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
