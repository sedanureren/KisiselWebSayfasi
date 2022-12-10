using Microsoft.AspNetCore.Mvc;

namespace KisiselWebSayfasi.Controllers
{
    public class AnaSayfaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
