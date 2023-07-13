using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home")]
        [Route("/")]
        public IActionResult Index() => Content("Home");

        [Route("/Home/Info")]
        [Route("/Home/{id:int}")]
        public IActionResult Index2() => Content("<h1>Info<h1/>", "text/html");

        [Route("Hello")]
        public IActionResult Index3()
        {
            Employee emp = new Employee()
            {
                Id = 1,
                Name = "Abdalla",
                Description = "Hello",
                Title = "Back End Developer"
            };
            return Json(emp);
        }
    }
}
