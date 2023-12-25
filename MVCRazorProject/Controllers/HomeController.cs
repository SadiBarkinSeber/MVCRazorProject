using Microsoft.AspNetCore.Mvc;
using MVCRazorProject.Models;
using System.Diagnostics;

namespace MVCRazorProject.Controllers
{
    public class HomeController : Controller
    {
     
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Kullanıcı()
        {
            Kullanici kullanıcı = new Kullanici();
            kullanıcı.Ad = "Barkın";
            kullanıcı.Soyad = "Şeber";
            return View(kullanıcı);
        }



    }
}