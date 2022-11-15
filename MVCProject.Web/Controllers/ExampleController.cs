using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Web.Controllers
{
    public class ExampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NoLayoutPage()
        {
            return View();
        }
    }
}

