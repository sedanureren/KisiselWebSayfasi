using Microsoft.AspNetCore.Mvc;

namespace KisiselWebSayfasi.Controllers
{
    public class SehrimController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            return PartialView();
        }
    }
}