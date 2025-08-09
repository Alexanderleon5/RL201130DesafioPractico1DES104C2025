using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RL201130DesafioPractico1DES104C2025.Models;
using System.Configuration;
using System.Diagnostics;

namespace RL201130DesafioPractico1DES104C2025.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        }
    }

