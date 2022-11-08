using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return RedirectToAction("Index","Test");
        }
        public IActionResult ContentResult()
        {
            return Content("Content Result is here");
        }
        public IActionResult JsonResult()
        {
            return Json(new { Id = 1, Name = "Book", UnitPrice = 18 });
        }
        public IActionResult EmptyResult()
        {
            return new EmptyResult();
        }
    }
}
