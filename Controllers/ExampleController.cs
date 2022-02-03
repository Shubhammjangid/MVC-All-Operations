using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Memory;
using System;

namespace WebApplication1.Controllers
{
    
    public class ExampleController : Controller
    {
        


        public IActionResult Index()
        {
            var data = GetEmolpyee();
            return View(data);
        }
        
        public Employee GetEmolpyee()
        {
            return new Employee()
            {
                Name = "Shubam",
                Age = 20,
                City = "Pune"
            };
        }

        public IActionResult Testing()
        {
            var data = GetEmolpyee();
            return View(data);
        }

        public IActionResult StudentModel()
        {
            ViewBag.MyFirstName = "This is view bag";
            ViewBag.MyList = new List<string>(){"Shubham","Vijay","Abhi","Sahil"};

            ViewData["Emply"] = new List<int>(){1,2,3,4,5,6};
            return View();

            

        }

        public IActionResult Res()
        {
            return View();
        }

       
    }
   
}
