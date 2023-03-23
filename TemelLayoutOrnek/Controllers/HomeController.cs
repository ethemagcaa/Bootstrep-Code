using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TemelLayoutOrnek.Models;

namespace TemelLayoutOrnek.Controllers
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
        public IActionResult Gorunum()
        {
            return View();  
        }
        public IActionResult Gorunum2()
        {
            return View();
        }

        public IActionResult Gorunum3()
        {
            return View();
        }

        public IActionResult MListele() 
        {
            return View(TemelLayoutOrnek.Musteriveri.Musteriveri.KMusteri);
        }
        public IActionResult YeniKayit() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniKayit(Models.Musteri yeniMusteri)
        {
            TemelLayoutOrnek.Musteriveri.Musteriveri.KMusteri.Add(yeniMusteri);
            return RedirectToAction("MListele");
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