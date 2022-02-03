using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpPost]
        public ActionResult Registration(Models.Registration objEmp)
        {
            try
            {
                if (objEmp.Email == "abc@mail.com")  
                    {  
                    ModelState.AddModelError("", "Email can not be 'abc@mail.com'");  
                    } 
                if (ModelState.IsValid)
                { 
                    return Content("EmployeeModel is Valid.."); 
                }
                else
                {
                    return View(objEmp);
                }
            }
            catch
            {
                return View(objEmp);
            }
            
        }

        public IActionResult Index()
        {
            return View();
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
