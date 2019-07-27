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
            using (BuyItContext  buyItContext=new BuyItContext())
            {
                List<User> users=buyItContext.Users.Include(a=>a.Addresses).ToList();
                List<Address> addresses = buyItContext.Addresses.Include(a => a.User).ToList();



            }

            return View();
        }
    }
}
