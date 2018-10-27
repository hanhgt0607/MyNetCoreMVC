using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyNetCoreMVC.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetList()
        {
            return View();
        }
        public IActionResult Create(string name , string price)
        {
            ViewData["name"] = name;
            ViewData["price"] = price;

            return View();
        }
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            return new JsonResult(new Models.Product()
            {
                id = id
            });
        }
    }
}