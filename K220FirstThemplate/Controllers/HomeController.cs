using K220FirstThemplate.Models;
using K220FirstThemplate.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace K220FirstThemplate.Controllers
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
            ButenDbContext db = new();
            HomeVM vm = new()
            {
                Section1 = db.Section1s.FirstOrDefault(),
                Section2 = db.Section2s.FirstOrDefault(),
                FeatureList = db.Features.ToList(),
                ListProducts=db.Products.Include(p=>p.Category).ToList()
            };
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult About()
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