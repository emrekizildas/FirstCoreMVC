using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstCoreMVC.Models;

namespace FirstCoreMVC.Controllers
{
    public class HomeController : Controller
    {
        public Context _db;

        public HomeController()
        {
            _db = new Context();
        }

        public IActionResult Index()
        {
            return View(_db.Products.ToList());
        }

        public IActionResult Doing()
        {
            return View();
        }

        public IActionResult Done()
        {
            return View();
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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