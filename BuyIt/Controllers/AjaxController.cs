using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BuyIt.Controllers
{
    public class AjaxController : Controller
    {
        [Route("/api")]
        public IActionResult Handle()
        {
            string json= HttpContext.Request.Form["JSON"].ToString();
            DTO.ProductSaveDto productSave= Newtonsoft.Json.JsonConvert.DeserializeObject<DTO.ProductSaveDto>(json);

            using (BuyItContext buyItContext=new BuyItContext())
            {
                buyItContext.Products.Add(new Models.Product()
                {
                    Name = productSave.productName,
                    Description = "boş",
                    CreateDate = DateTime.UtcNow,
                    StateId =  (int)Enums.State.Active, 
                    CategoryId = productSave.categoryId
                });

                buyItContext.SaveChanges();
            }

            return View();
        }
    }
}