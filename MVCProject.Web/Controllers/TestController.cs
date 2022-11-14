using Microsoft.AspNetCore.Mvc;

namespace MVCProject.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.name = "Asp.Net Core MVC";
            ViewData["name"] = "MVC Project";
            ViewData["names"] = new List<string> { "xyz", "zyx", "jyz" };

            ViewBag.persons = new { Id = 1, Name = "Furkan", Surname = "Bircan" };

            TempData["customer"] = "JEFF";
            return View();
        }
        public IActionResult Index2()
        {
            var surname = TempData["customer"];
            return View();
        }
        public IActionResult IndexParameter(int id)
        {
            return RedirectToAction("JsonParameter", "Test", new { Id = id });
        }
        public IActionResult JsonParameter(int id)
        {
            return Json(new { Id = id });
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
