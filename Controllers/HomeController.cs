using Microsoft.AspNetCore.Mvc;


namespace Pronia1.Controllers
{
    public class HomeController : Controller
    {


        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

    }  
}
