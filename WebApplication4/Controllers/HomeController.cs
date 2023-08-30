using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home")]
        [Route("/")]
        public IActionResult Index() => StatusCode(200, "Welcome to the Best Bank");

        [Route("account-details")]
        public IActionResult Index3()
        {

            BankModel model = new BankModel();
            model.accountNumber = 1001;
            model.accountHolderName = "Example Name";
            model.currentBalnce = 5000.00M;
            return StatusCode(200, model);
        }

        [Route("account-statement)]
        //[Route("/Home/{id:int}")]
        public IActionResult Index2() => Content("<h1>Info<h1/>", "text/html");

        
    }


    public class BankModel
    {
        public int accountNumber { get; set; }
        public string? accountHolderName { get; set; }
        public decimal currentBalnce { get; set; }

    }
}
