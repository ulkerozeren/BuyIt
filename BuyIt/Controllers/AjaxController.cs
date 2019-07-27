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
            DTO.ProductSaveDto categorySave= Newtonsoft.Json.JsonConvert.DeserializeObject<DTO.ProductSaveDto>(json);

            using (BuyItContext buyItContext=new BuyItContext())
            {
                buyItContext.Products.Add(new Models.Product()
                {
                    Name = categorySave.productName,
                    Description = "boş",
                    CreateDate=DateTime.UtcNow,
                    State=buyItContext.States.Single(a=>a.Id==(int)Enums.State.Active)
                });
            }

            return View();
        }
    }
}