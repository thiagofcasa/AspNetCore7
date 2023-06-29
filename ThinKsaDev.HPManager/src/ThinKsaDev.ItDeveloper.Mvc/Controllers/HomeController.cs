using Cooperchip.ItDeveloper.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.Diagnostics;
using ThinKsaDev.ItDeveloper.Mvc.Controllers;

namespace Cooperchip.ItDeveloper.Mvc.Controllers
{
    [Route("")]
    [Route("initial-page")]
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("")]
        [Route("dashboard")]
        [Route("analytical-board")]
        public IActionResult Dashboard()
        {
            return View();
        }

        [Route("privacy")]
        [Route("privacy-policy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [Route("errors")]
        [Route("error-management")]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}