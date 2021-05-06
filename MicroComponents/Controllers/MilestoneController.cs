using MicroComponents.Models;
using MicroProxyApiClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MicroComponents.Controllers
{
    public class MilestoneController : Controller
    {
        private readonly ILogger<MilestoneController> _logger;

        public MilestoneController(ILogger<MilestoneController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Include a simple blazor component, contained in a razor class library, in an existing ASP.NET Core MVC app
        /// </summary>
        /// <returns></returns>
        public IActionResult Milestone1()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IActionResult> Milestone2()
        {
            ProxyService proxySvc = new ProxyService();
            var weatherForecastViewModel = await proxySvc.GetViewModel();          

            return View(weatherForecastViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
