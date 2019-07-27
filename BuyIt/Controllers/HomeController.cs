using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BuyIt.Models;
using Microsoft.EntityFrameworkCore;

namespace BuyIt.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "HOŞ GELDİNİZ";
            return View();
        }

        public IActionResult Help()
        {
            ViewData["Title"] = "YARDIM MASASI";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Title"] = "İLETİŞİM";
            return View();
        }

    }
}
