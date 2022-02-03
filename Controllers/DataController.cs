using Microsoft.AspNetCore.Mvc;


namespace WebApplication1.Controllers
{
    public class DataController : Controller
    {
        public IActionResult Registration()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registration(Models.Registration objEmp)
        {
            try
            {
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

    }
}
