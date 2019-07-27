using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuyIt.Models;
using Microsoft.AspNetCore.Mvc;

namespace BuyIt.Controllers
{
    public class CategoryController : Controller
    {
        [Route("/kategori/{id}")]
        public IActionResult Index(int id)
        {
            Category category = new Category();

            using (BuyItContext buyItContext=new BuyItContext ())
            {
                category = buyItContext.Categories.SingleOrDefault(x => x.Id == id);
               
            }

            ViewData["Title"] = category.Name;
            return View(category);
        }
    }
}