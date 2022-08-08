﻿using K220FirstThemplate.Models;
using K220FirstThemplate.ViewModels;
using Microsoft.AspNetCore.Mvc;
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

            HomeVM vm = new();
            vm.Section1 = db.Section1s.First();
            vm.Section2 = db.Section2s.First();

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