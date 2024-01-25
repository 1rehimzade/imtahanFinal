
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Imtahanbilet9.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        } 
    }
}